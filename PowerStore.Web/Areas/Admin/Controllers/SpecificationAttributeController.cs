﻿using PowerStore.Core;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Seo;
using PowerStore.Framework.Kendoui;
using PowerStore.Framework.Mvc;
using PowerStore.Framework.Mvc.Filters;
using PowerStore.Framework.Security.Authorization;
using PowerStore.Services.Catalog;
using PowerStore.Services.Localization;
using PowerStore.Services.Logging;
using PowerStore.Services.Security;
using PowerStore.Services.Seo;
using PowerStore.Services.Stores;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Catalog;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Controllers
{
    [PermissionAuthorize(PermissionSystemName.SpecificationAttributes)]
    public partial class SpecificationAttributeController : BaseAdminController
    {
        #region Fields

        private readonly ISpecificationAttributeService _specificationAttributeService;
        private readonly ILanguageService _languageService;
        private readonly ILocalizationService _localizationService;
        private readonly ICustomerActivityService _customerActivityService;
        private readonly IStoreService _storeService;
        private readonly IWorkContext _workContext;
        private readonly SeoSettings _seoSettings;

        #endregion Fields

        #region Constructors

        public SpecificationAttributeController(ISpecificationAttributeService specificationAttributeService,
            ILanguageService languageService,
            ILocalizationService localizationService,
            ICustomerActivityService customerActivityService,
            IStoreService storeService,
            IWorkContext workContext,
            SeoSettings seoSettings)
        {
            _specificationAttributeService = specificationAttributeService;
            _languageService = languageService;
            _localizationService = localizationService;
            _customerActivityService = customerActivityService;
            _storeService = storeService;
            _workContext = workContext;
            _seoSettings = seoSettings;
        }

        #endregion

        #region Specification attributes

        //list
        public IActionResult Index() => RedirectToAction("List");

        public IActionResult List() => View();

        [HttpPost]
        [PermissionAuthorizeAction(PermissionActionName.List)]
        public async Task<IActionResult> List(DataSourceRequest command)
        {
            var specificationAttributes = await _specificationAttributeService
                .GetSpecificationAttributes(command.Page - 1, command.PageSize);
            var gridModel = new DataSourceResult {
                Data = specificationAttributes.Select(x => x.ToModel()),
                Total = specificationAttributes.TotalCount
            };

            return Json(gridModel);
        }

        //create
        [PermissionAuthorizeAction(PermissionActionName.Create)]
        public async Task<IActionResult> Create()
        {
            var model = new SpecificationAttributeModel();
            //locales
            await AddLocales(_languageService, model.Locales);
            //Stores
            await model.PrepareStoresMappingModel(null, _storeService, false, _workContext.CurrentCustomer.StaffStoreId);

            return View(model);
        }

        [HttpPost, ParameterBasedOnFormName("save-continue", "continueEditing")]
        [PermissionAuthorizeAction(PermissionActionName.Create)]
        public async Task<IActionResult> Create(SpecificationAttributeModel model, bool continueEditing)
        {
            if (ModelState.IsValid)
            {
                var specificationAttribute = model.ToEntity();
                specificationAttribute.SeName = SeoExtensions.GetSeName(string.IsNullOrEmpty(specificationAttribute.SeName) ? specificationAttribute.Name : specificationAttribute.SeName, _seoSettings);
                if (_workContext.CurrentCustomer.IsStaff())
                {
                    model.LimitedToStores = true;
                    model.SelectedStoreIds = new string[] { _workContext.CurrentCustomer.StaffStoreId };
                }
                await _specificationAttributeService.InsertSpecificationAttribute(specificationAttribute);
                //activity log
                await _customerActivityService.InsertActivity("AddNewSpecAttribute", specificationAttribute.Id, _localizationService.GetResource("ActivityLog.AddNewSpecAttribute"), specificationAttribute.Name);
                SuccessNotification(_localizationService.GetResource("Admin.Catalog.Attributes.SpecificationAttributes.Added"));
                return continueEditing ? RedirectToAction("Edit", new { id = specificationAttribute.Id }) : RedirectToAction("List");
            }

            //If we got this far, something failed, redisplay form
            return View(model);
        }

        //edit
        [PermissionAuthorizeAction(PermissionActionName.Preview)]
        public async Task<IActionResult> Edit(string id)
        {
            var specificationAttribute = await _specificationAttributeService.GetSpecificationAttributeById(id);
            if (specificationAttribute == null)
                //No specification attribute found with the specified id
                return RedirectToAction("List");

            var model = specificationAttribute.ToModel();
            //locales
            await AddLocales(_languageService, model.Locales, (locale, languageId) =>
            {
                locale.Name = specificationAttribute.GetLocalized(x => x.Name, languageId, false, false);
            });
            //Stores
            await model.PrepareStoresMappingModel(specificationAttribute, _storeService, false, _workContext.CurrentCustomer.StaffStoreId);

            return View(model);
        }

        [HttpPost, ParameterBasedOnFormName("save-continue", "continueEditing")]
        [PermissionAuthorizeAction(PermissionActionName.Edit)]
        public async Task<IActionResult> Edit(SpecificationAttributeModel model, bool continueEditing)
        {
            var specificationAttribute = await _specificationAttributeService.GetSpecificationAttributeById(model.Id);
            if (specificationAttribute == null)
                //No specification attribute found with the specified id
                return RedirectToAction("List");

            if (ModelState.IsValid)
            {
                specificationAttribute = model.ToEntity(specificationAttribute);
                specificationAttribute.SeName = SeoExtensions.GetSeName(string.IsNullOrEmpty(specificationAttribute.SeName) ? specificationAttribute.Name : specificationAttribute.SeName, _seoSettings);
                if (_workContext.CurrentCustomer.IsStaff())
                {
                    model.LimitedToStores = true;
                    model.SelectedStoreIds = new string[] { _workContext.CurrentCustomer.StaffStoreId };
                }
                await _specificationAttributeService.UpdateSpecificationAttribute(specificationAttribute);
                //activity log
                await _customerActivityService.InsertActivity("EditSpecAttribute", specificationAttribute.Id, _localizationService.GetResource("ActivityLog.EditSpecAttribute"), specificationAttribute.Name);

                SuccessNotification(_localizationService.GetResource("Admin.Catalog.Attributes.SpecificationAttributes.Updated"));

                if (continueEditing)
                {
                    //selected tab
                    await SaveSelectedTabIndex();

                    return RedirectToAction("Edit", new { id = specificationAttribute.Id });
                }
                return RedirectToAction("List");
            }

            //If we got this far, something failed, redisplay form
            //Stores
            await model.PrepareStoresMappingModel(specificationAttribute, _storeService, false, _workContext.CurrentCustomer.StaffStoreId);
            //locales
            await AddLocales(_languageService, model.Locales, (locale, languageId) =>
            {
                locale.Name = specificationAttribute.GetLocalized(x => x.Name, languageId, false, false);
            });
            return View(model);
        }

        //delete
        [HttpPost]
        [PermissionAuthorizeAction(PermissionActionName.Delete)]
        public async Task<IActionResult> Delete(string id)
        {
            var specificationAttribute = await _specificationAttributeService.GetSpecificationAttributeById(id);
            if (specificationAttribute == null)
                //No specification attribute found with the specified id
                return RedirectToAction("List");
            if (ModelState.IsValid)
            {
                await _specificationAttributeService.DeleteSpecificationAttribute(specificationAttribute);

                //activity log
                await _customerActivityService.InsertActivity("DeleteSpecAttribute", specificationAttribute.Id, _localizationService.GetResource("ActivityLog.DeleteSpecAttribute"), specificationAttribute.Name);

                SuccessNotification(_localizationService.GetResource("Admin.Catalog.Attributes.SpecificationAttributes.Deleted"));
                return RedirectToAction("List");
            }
            ErrorNotification(ModelState);
            return RedirectToAction("Edit", new { id = specificationAttribute.Id });
        }

        #endregion

        #region Specification attribute options

        //list
        [HttpPost]
        [PermissionAuthorizeAction(PermissionActionName.Preview)]
        public async Task<IActionResult> OptionList(string specificationAttributeId, DataSourceRequest command)
        {
            var options = (await _specificationAttributeService.GetSpecificationAttributeById(specificationAttributeId)).SpecificationAttributeOptions.OrderBy(x => x.DisplayOrder);
            var gridModel = new DataSourceResult {
                Data = options.Select(x =>
                    {
                        var model = x.ToModel();
                        //in order to save performance to do not check whether a product is deleted, etc
                        model.NumberOfAssociatedProducts = _specificationAttributeService
                            .GetProductSpecificationAttributeCount("", x.Id);
                        return model;
                    }),
                Total = options.Count()
            };

            return Json(gridModel);
        }

        //create
        [PermissionAuthorizeAction(PermissionActionName.Edit)]
        public async Task<IActionResult> OptionCreatePopup(string specificationAttributeId)
        {
            var model = new SpecificationAttributeOptionModel {
                SpecificationAttributeId = specificationAttributeId
            };
            //locales
            await AddLocales(_languageService, model.Locales);
            return View(model);
        }

        [HttpPost]
        [PermissionAuthorizeAction(PermissionActionName.Edit)]
        public async Task<IActionResult> OptionCreatePopup(SpecificationAttributeOptionModel model)
        {
            var specificationAttribute = await _specificationAttributeService.GetSpecificationAttributeById(model.SpecificationAttributeId);
            if (specificationAttribute == null)
                //No specification attribute found with the specified id
                return RedirectToAction("List");

            if (ModelState.IsValid)
            {
                var sao = model.ToEntity();
                sao.SeName = SeoExtensions.GetSeName(string.IsNullOrEmpty(sao.SeName) ? sao.Name : sao.SeName, _seoSettings);
                //clear "Color" values if it's disabled
                if (!model.EnableColorSquaresRgb)
                    sao.ColorSquaresRgb = null;

                specificationAttribute.SpecificationAttributeOptions.Add(sao);
                await _specificationAttributeService.UpdateSpecificationAttribute(specificationAttribute);

                ViewBag.RefreshPage = true;
                return View(model);
            }

            //If we got this far, something failed, redisplay form
            return View(model);
        }

        //edit
        [PermissionAuthorizeAction(PermissionActionName.Edit)]
        public async Task<IActionResult> OptionEditPopup(string id)
        {
            var sao = (await _specificationAttributeService.GetSpecificationAttributeByOptionId(id)).SpecificationAttributeOptions.Where(x => x.Id == id).FirstOrDefault();
            if (sao == null)
                //No specification attribute option found with the specified id
                return RedirectToAction("List");

            var model = sao.ToModel();
            model.EnableColorSquaresRgb = !String.IsNullOrEmpty(sao.ColorSquaresRgb);
            //locales
            await AddLocales(_languageService, model.Locales, (locale, languageId) =>
            {
                locale.Name = sao.GetLocalized(x => x.Name, languageId, false, false);
            });

            return View(model);
        }

        [HttpPost]
        [PermissionAuthorizeAction(PermissionActionName.Edit)]
        public async Task<IActionResult> OptionEditPopup(SpecificationAttributeOptionModel model)
        {
            var specificationAttribute = await _specificationAttributeService.GetSpecificationAttributeByOptionId(model.Id);
            var sao = specificationAttribute.SpecificationAttributeOptions.Where(x => x.Id == model.Id).FirstOrDefault();
            if (sao == null)
                //No specification attribute option found with the specified id
                return RedirectToAction("List");

            if (ModelState.IsValid)
            {
                sao = model.ToEntity(sao);
                sao.SeName = SeoExtensions.GetSeName(string.IsNullOrEmpty(sao.SeName) ? sao.Name : sao.SeName, _seoSettings);

                //clear "Color" values if it's disabled
                if (!model.EnableColorSquaresRgb)
                    sao.ColorSquaresRgb = null;

                await _specificationAttributeService.UpdateSpecificationAttribute(specificationAttribute);

                ViewBag.RefreshPage = true;
                return View(model);
            }

            //If we got this far, something failed, redisplay form
            return View(model);
        }

        //delete
        [HttpPost]
        [PermissionAuthorizeAction(PermissionActionName.Edit)]
        public async Task<IActionResult> OptionDelete(string id)
        {
            if (ModelState.IsValid)
            {
                var specificationAttribute = await _specificationAttributeService.GetSpecificationAttributeByOptionId(id);
                var sao = specificationAttribute.SpecificationAttributeOptions.Where(x => x.Id == id).FirstOrDefault();
                if (sao == null)
                    throw new ArgumentException("No specification attribute option found with the specified id");

                await _specificationAttributeService.DeleteSpecificationAttributeOption(sao);

                return new NullJsonResult();
            }
            return ErrorForKendoGridJson(ModelState);
        }
        #endregion
    }
}
