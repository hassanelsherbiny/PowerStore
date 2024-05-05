using PowerStore.Framework.Controllers;
using PowerStore.Framework.Kendoui;
using PowerStore.Framework.Mvc;
using PowerStore.Framework.Mvc.Filters;
using PowerStore.Framework.Security.Authorization;
using PowerStore.Plugin.Tax.FixedRate.Models;
using PowerStore.Services.Configuration;
using PowerStore.Services.Security;
using PowerStore.Services.Tax;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Plugin.Tax.FixedRate.Controllers
{
    [AuthorizeAdmin]
    [Area("Admin")]
    [PermissionAuthorize(PermissionSystemName.TaxSettings)]
    public class TaxFixedRateController : BasePluginController
    {
        private readonly ITaxCategoryService _taxCategoryService;
        private readonly ISettingService _settingService;

        public TaxFixedRateController(ITaxCategoryService taxCategoryService, ISettingService settingService)
        {
            _taxCategoryService = taxCategoryService;
            _settingService = settingService;
        }


        public IActionResult Configure()
        {
            return View("~/Plugins/Tax.FixedRate/Views/Configure.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Configure(DataSourceRequest command)
        {
            var taxRateModels = new List<FixedTaxRateModel>();
            foreach (var taxCategory in await _taxCategoryService.GetAllTaxCategories())
                taxRateModels.Add(new FixedTaxRateModel
                {
                    TaxCategoryId = taxCategory.Id,
                    TaxCategoryName = taxCategory.Name,
                    Rate = GetTaxRate(taxCategory.Id)
                });

            var gridModel = new DataSourceResult
            {
                Data = taxRateModels,
                Total = taxRateModels.Count
            };
            return Json(gridModel);
        }

        [HttpPost]
        public async Task<IActionResult> TaxRateUpdate(FixedTaxRateModel model)
        {
            string taxCategoryId = model.TaxCategoryId;
            decimal rate = model.Rate;

            await _settingService.SetSetting(string.Format("Tax.TaxProvider.FixedRate.TaxCategoryId{0}", taxCategoryId), rate);

            return new NullJsonResult();
        }

        [NonAction]
        protected decimal GetTaxRate(string taxCategoryId)
        {
            var rate = _settingService.GetSettingByKey<decimal>(string.Format("Tax.TaxProvider.FixedRate.TaxCategoryId{0}", taxCategoryId));
            return rate;
        }
    }
}
