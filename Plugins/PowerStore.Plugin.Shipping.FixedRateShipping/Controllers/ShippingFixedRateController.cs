using PowerStore.Framework.Controllers;
using PowerStore.Framework.Kendoui;
using PowerStore.Framework.Mvc;
using PowerStore.Framework.Mvc.Filters;
using PowerStore.Framework.Security;
using PowerStore.Plugin.Shipping.FixedRateShipping.Models;
using PowerStore.Services.Configuration;
using PowerStore.Services.Security;
using PowerStore.Services.Shipping;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Plugin.Shipping.FixedRateShipping.Controllers
{
    [Area("Admin")]
    [AuthorizeAdmin]
    public class ShippingFixedRateController : BaseShippingController
    {
        private readonly IShippingMethodService _shippingMethodService;
        private readonly ISettingService _settingService;
        private readonly IPermissionService _permissionService;

        public ShippingFixedRateController(
            IShippingMethodService shippingMethodService,
            ISettingService settingService, 
            IPermissionService permissionService)
        {
            _shippingMethodService = shippingMethodService;
            _settingService = settingService;
            _permissionService = permissionService;
        }
        
        public IActionResult Configure()
        {
            return View("~/Plugins/Shipping.FixedRateShipping/Views/ShippingFixedRate/Configure.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Configure(DataSourceRequest command)
        {
            if (!await _permissionService.Authorize(StandardPermissionProvider.ManageShippingSettings))
                return Content("Access denied");

            var rateModels = new List<FixedShippingRateModel>();
            foreach (var shippingMethod in await _shippingMethodService.GetAllShippingMethods())
                rateModels.Add(new FixedShippingRateModel
                {
                    ShippingMethodId = shippingMethod.Id,
                    ShippingMethodName = shippingMethod.Name,
                    Rate = GetShippingRate(shippingMethod.Id)
                });

            var gridModel = new DataSourceResult
            {
                Data = rateModels,
                Total = rateModels.Count
            };
            return Json(gridModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ShippingRateUpdate(FixedShippingRateModel model)
        {
            if (!await _permissionService.Authorize(StandardPermissionProvider.ManageShippingSettings))
                return Content("Access denied");

            string shippingMethodId = model.ShippingMethodId;
            decimal rate = model.Rate;

            await _settingService.SetSetting(string.Format("ShippingRateComputationMethod.FixedRate.Rate.ShippingMethodId{0}", shippingMethodId), rate);

            return new NullJsonResult();
        }

        [NonAction]
        protected decimal GetShippingRate(string shippingMethodId)
        {
            var rate = _settingService.GetSettingByKey<decimal>(string.Format("ShippingRateComputationMethod.FixedRate.Rate.ShippingMethodId{0}", shippingMethodId));
            return rate;
        }
    }
}