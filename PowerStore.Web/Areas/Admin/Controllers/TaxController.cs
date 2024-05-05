using PowerStore.Core;
using PowerStore.Core.Caching;
using PowerStore.Domain.Tax;
using PowerStore.Framework.Kendoui;
using PowerStore.Framework.Mvc;
using PowerStore.Framework.Security.Authorization;
using PowerStore.Services.Configuration;
using PowerStore.Services.Security;
using PowerStore.Services.Tax;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Tax;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Controllers
{
    [PermissionAuthorize(PermissionSystemName.TaxSettings)]
    public partial class TaxController : BaseAdminController
	{
		#region Fields

        private readonly ITaxService _taxService;
        private readonly ITaxCategoryService _taxCategoryService;
        private readonly TaxSettings _taxSettings;
        private readonly ISettingService _settingService;
        private readonly IServiceProvider _serviceProvider;
        private readonly ICacheBase _cacheBase;
	    #endregion

		#region Constructors

        public TaxController(ITaxService taxService,
            ITaxCategoryService taxCategoryService, TaxSettings taxSettings,
            ISettingService settingService, IServiceProvider serviceProvider,
            ICacheBase cacheBase)
		{
            _taxService = taxService;
            _taxCategoryService = taxCategoryService;
            _taxSettings = taxSettings;
            _settingService = settingService;
            _serviceProvider = serviceProvider;
            _cacheBase = cacheBase;
        }

        #endregion

        #region Tax Providers
        protected async Task ClearCache()
        {
            await _cacheBase.Clear();
        }

        public IActionResult Providers() => View();

        [HttpPost]
        public IActionResult Providers(DataSourceRequest command)
        {
            var taxProviders = _taxService.LoadAllTaxProviders()
                .ToList();
            var taxProvidersModel = new List<TaxProviderModel>();
            foreach (var tax in taxProviders)
            {
                var tmp1 = tax.ToModel();
                tmp1.ConfigurationUrl = tax.PluginDescriptor.Instance(_serviceProvider).GetConfigurationPageUrl();
                tmp1.IsPrimaryTaxProvider = tmp1.SystemName.Equals(_taxSettings.ActiveTaxProviderSystemName, StringComparison.OrdinalIgnoreCase);
                taxProvidersModel.Add(tmp1);
            }
            var gridModel = new DataSourceResult
            {
                Data = taxProvidersModel,
                Total = taxProvidersModel.Count()
            };

            return Json(gridModel);
        }

        public async Task<IActionResult> MarkAsPrimaryProvider(string systemName)
        {
            if (String.IsNullOrEmpty(systemName))
            {
                return RedirectToAction("Providers");
            }
            var taxProvider = _taxService.LoadTaxProviderBySystemName(systemName);
            if (taxProvider != null)
            {
                _taxSettings.ActiveTaxProviderSystemName = systemName;
                await _settingService.SaveSetting(_taxSettings);
            }

            //now clear cache
            await ClearCache();

            return RedirectToAction("Providers");
        }

        #endregion

        #region Tax Categories

        public IActionResult Categories() => View();

        [HttpPost]
        public async Task<IActionResult> Categories(DataSourceRequest command)
        {
            var categoriesModel = (await _taxCategoryService.GetAllTaxCategories())
                .Select(x => x.ToModel())
                .ToList();
            var gridModel = new DataSourceResult
            {
                Data = categoriesModel,
                Total = categoriesModel.Count
            };

            return Json(gridModel);
        }

        [HttpPost]
        public async Task<IActionResult> CategoryUpdate(TaxCategoryModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new DataSourceResult { Errors = ModelState.SerializeErrors() });
            }

            var taxCategory = await _taxCategoryService.GetTaxCategoryById(model.Id);
            taxCategory = model.ToEntity(taxCategory);
            await _taxCategoryService.UpdateTaxCategory(taxCategory);

            return new NullJsonResult();
        }

        [HttpPost]
        public async Task<IActionResult> CategoryAdd( TaxCategoryModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new DataSourceResult { Errors = ModelState.SerializeErrors() });
            }

            var taxCategory = new TaxCategory();
            taxCategory = model.ToEntity(taxCategory);
            await _taxCategoryService.InsertTaxCategory(taxCategory);

            return new NullJsonResult();
        }

        [HttpPost]
        public async Task<IActionResult> CategoryDelete(string id)
        {
            var taxCategory = await _taxCategoryService.GetTaxCategoryById(id);
            if (taxCategory == null)
                throw new ArgumentException("No tax category found with the specified id");
            await _taxCategoryService.DeleteTaxCategory(taxCategory);

            return new NullJsonResult();
        }

        #endregion
    }
}
