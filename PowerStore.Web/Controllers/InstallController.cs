﻿using PowerStore.Core;
using PowerStore.Core.Caching;
using PowerStore.Core.Configuration;
using PowerStore.Core.Data;
using PowerStore.Core.Plugins;
using PowerStore.Domain.Data;
using PowerStore.Framework.Security;
using PowerStore.Services.Commands.Models.Security;
using PowerStore.Services.Installation;
using PowerStore.Services.Logging;
using PowerStore.Services.Security;
using PowerStore.Web.Models.Install;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace PowerStore.Web.Controllers
{
    public partial class InstallController : Controller
    {
        #region Fields

        private readonly PowerStoreConfig _config;
        private readonly ICacheBase _cacheBase;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMediator _mediator;
        #endregion

        #region Ctor

        public InstallController(PowerStoreConfig config, ICacheBase cacheManager,
            IServiceProvider serviceProvider, IMediator mediator)
        {
            _config = config;
            _cacheBase = cacheManager;
            _serviceProvider = serviceProvider;
            _mediator = mediator;
        }

        #endregion

        #region Methods

        public virtual async Task<IActionResult> Index()
        {
            if (DataSettingsHelper.DatabaseIsInstalled())
                return RedirectToRoute("HomePage");

            var locService = _serviceProvider.GetRequiredService<IInstallationLocalizationService>();

            var installed = await _cacheBase.GetAsync("Installed", async () => { return await Task.FromResult(false); });
            if (installed)
                return View(new InstallModel() { Installed = true });

            var model = new InstallModel {
                AdminEmail = "admin@yourstore.com",
                InstallSampleData = false,
                DatabaseConnectionString = "",
                DataProvider = "mongodb",
            };
            foreach (var lang in locService.GetAvailableLanguages())
            {
                model.AvailableLanguages.Add(new SelectListItem {
                    Value = Url.Action("ChangeLanguage", "Install", new { language = lang.Code }),
                    Text = lang.Name,
                    Selected = locService.GetCurrentLanguage().Code == lang.Code,
                });
            }
            //prepare collation list
            foreach (var col in locService.GetAvailableCollations())
            {
                model.AvailableCollation.Add(new SelectListItem {
                    Value = col.Value,
                    Text = col.Name,
                    Selected = locService.GetCurrentLanguage().Code == col.Value,
                });
            }
            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Index(InstallModel model)
        {
            if (DataSettingsHelper.DatabaseIsInstalled())
                return RedirectToRoute("HomePage");

            var locService = _serviceProvider.GetRequiredService<IInstallationLocalizationService>();

            if (model.DatabaseConnectionString != null)
                model.DatabaseConnectionString = model.DatabaseConnectionString.Trim();

            string connectionString = "";

            if (model.MongoDBConnectionInfo)
            {
                if (String.IsNullOrEmpty(model.DatabaseConnectionString))
                {
                    ModelState.AddModelError("", locService.GetResource("ConnectionStringRequired"));
                }
                else
                {
                    connectionString = model.DatabaseConnectionString;
                }
            }
            else
            {
                if (String.IsNullOrEmpty(model.MongoDBDatabaseName))
                {
                    ModelState.AddModelError("", locService.GetResource("DatabaseNameRequired"));
                }
                if (String.IsNullOrEmpty(model.MongoDBServerName))
                {
                    ModelState.AddModelError("", locService.GetResource("MongoDBServerNameRequired"));
                }
                string userNameandPassword = "";
                if (!(String.IsNullOrEmpty(model.MongoDBUsername)))
                {
                    userNameandPassword = model.MongoDBUsername + ":" + model.MongoDBPassword + "@";
                }

                connectionString = "mongodb://" + userNameandPassword + model.MongoDBServerName + "/" + model.MongoDBDatabaseName;
            }

            if (!string.IsNullOrEmpty(connectionString))
            {
                try
                {
                    var client = new MongoClient(connectionString);
                    var databaseName = new MongoUrl(connectionString).DatabaseName;
                    var database = client.GetDatabase(databaseName);
                    await database.RunCommandAsync((Command<BsonDocument>)"{ping:1}");

                    var filter = new BsonDocument("name", "PowerStoreVersion");
                    var found = database.ListCollectionsAsync(new ListCollectionsOptions { Filter = filter }).Result;

                    if (found.Any())
                        ModelState.AddModelError("", locService.GetResource("AlreadyInstalled"));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                }
            }
            else
                ModelState.AddModelError("", locService.GetResource("ConnectionStringRequired"));

            var webHelper = _serviceProvider.GetRequiredService<IWebHelper>();

            //validate permissions
            var dirsToCheck = FilePermissionHelper.GetDirectoriesWrite();
            foreach (string dir in dirsToCheck)
                if (!FilePermissionHelper.CheckPermissions(dir, false, true, true, false))
                    ModelState.AddModelError("", string.Format(locService.GetResource("ConfigureDirectoryPermissions"), WindowsIdentity.GetCurrent().Name, dir));

            var filesToCheck = FilePermissionHelper.GetFilesWrite();
            foreach (string file in filesToCheck)
                if (!FilePermissionHelper.CheckPermissions(file, false, true, true, true))
                    ModelState.AddModelError("", string.Format(locService.GetResource("ConfigureFilePermissions"), WindowsIdentity.GetCurrent().Name, file));

            if (ModelState.IsValid)
            {
                var settingsManager = new DataSettingsManager();
                try
                {
                    //save settings
                    var settings = new DataSettings {
                        DataProvider = "mongodb",
                        DataConnectionString = connectionString
                    };
                    await settingsManager.SaveSettings(settings);

                    var dataProviderInstance = _serviceProvider.GetRequiredService<BaseDataProviderManager>().LoadDataProvider();
                    dataProviderInstance.InitDatabase();

                    var dataSettingsManager = new DataSettingsManager();
                    var dataProviderSettings = dataSettingsManager.LoadSettings(reloadSettings: true);

                    var installationService = _serviceProvider.GetRequiredService<IInstallationService>();
                    await installationService.InstallData(model.AdminEmail, model.AdminPassword, model.Collation, model.InstallSampleData, model.CompanyName, model.CompanyAddress, model.CompanyPhoneNumber, model.CompanyEmail);

                    //reset cache
                    DataSettingsHelper.ResetCache();

                    //install plugins
                    PluginManager.MarkAllPluginsAsUninstalled();
                    var pluginFinder = _serviceProvider.GetRequiredService<IPluginFinder>();
                    var plugins = pluginFinder.GetPlugins<IPlugin>(LoadPluginsMode.All)
                        .ToList()
                        .OrderBy(x => x.PluginDescriptor.Group)
                        .ThenBy(x => x.PluginDescriptor.DisplayOrder)
                        .ToList();

                    foreach (var plugin in plugins)
                    {
                        try
                        {
                            await plugin.Install();
                        }
                        catch (Exception ex)
                        {
                            var _logger = _serviceProvider.GetRequiredService<ILogger>();
                            await _logger.InsertLog(Domain.Logging.LogLevel.Error, "Error during installing plugin " + plugin.PluginDescriptor.SystemName,
                                ex.Message + " " + ex.InnerException?.Message);
                        }
                    }

                    //register default permissions
                    var permissionProviders = new List<Type>();
                    permissionProviders.Add(typeof(StandardPermissionProvider));
                    foreach (var providerType in permissionProviders)
                    {
                        var provider = (IPermissionProvider)Activator.CreateInstance(providerType);
                        await _mediator.Send(new InstallPermissionsCommand() { PermissionProvider = provider });
                    }

                    //restart application
                    await _cacheBase.SetAsync("Installed", true, 120);
                    return View(new InstallModel() { Installed = true });
                }
                catch (Exception exception)
                {
                    //reset cache
                    DataSettingsHelper.ResetCache();
                    await _cacheBase.Clear();

                    System.IO.File.Delete(CommonHelper.MapPath("~/App_Data/Settings.txt"));

                    ModelState.AddModelError("", string.Format(locService.GetResource("SetupFailed"), exception.Message + " " + exception.InnerException?.Message));
                }
            }

            //prepare language list
            foreach (var lang in locService.GetAvailableLanguages())
            {
                model.AvailableLanguages.Add(new SelectListItem {
                    Value = Url.Action("ChangeLanguage", "Install", new { language = lang.Code }),
                    Text = lang.Name,
                    Selected = locService.GetCurrentLanguage().Code == lang.Code,
                });
            }

            //prepare collation list
            foreach (var col in locService.GetAvailableCollations())
            {
                model.AvailableCollation.Add(new SelectListItem {
                    Value = col.Value,
                    Text = col.Name,
                    Selected = locService.GetCurrentLanguage().Code == col.Value,
                });
            }

            return View(model);
        }

        public virtual IActionResult ChangeLanguage(string language)
        {
            if (DataSettingsHelper.DatabaseIsInstalled())
                return RedirectToRoute("HomePage");

            var locService = _serviceProvider.GetRequiredService<IInstallationLocalizationService>();
            locService.SaveCurrentLanguage(language);

            //Reload the page
            return RedirectToAction("Index", "Install");
        }

        public virtual IActionResult RestartInstall()
        {
            if (DataSettingsHelper.DatabaseIsInstalled())
                return RedirectToRoute("HomePage");

            //restart application
            var webHelper = _serviceProvider.GetRequiredService<IWebHelper>();
            webHelper.StopApplication();

            //Redirect to home page
            return RedirectToRoute("HomePage");
        }

        #endregion
    }
}
