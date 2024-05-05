using PowerStore.Core;
using PowerStore.Plugin.Shipping.ShippingPoint.Models;
using PowerStore.Plugin.Shipping.ShippingPoint.Services;
using PowerStore.Services.Catalog;
using PowerStore.Services.Directory;
using PowerStore.Services.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Plugin.Shipping.ShippingPoint.Controllers
{
    public class SelectedShippingPointController : Controller
    {
        private readonly IShippingPointService _shippingPointService;
        private readonly ICountryService _countryService;
        private readonly IPriceFormatter _priceFormatter;

        public SelectedShippingPointController(IShippingPointService shippingPointService, ICountryService countryService, IPriceFormatter priceFormatter)
        {
            _shippingPointService = shippingPointService;
            _countryService = countryService;
            _priceFormatter = priceFormatter;
        }
        public async Task<IActionResult> Get(string shippingOptionId)
        {
            var shippingPoint = await _shippingPointService.GetStoreShippingPointById(shippingOptionId);
            if (shippingPoint != null)
            {
                var countryName = await _countryService.GetCountryById(shippingPoint.CountryId);

                var viewModel = new PointModel()
                {
                    ShippingPointName = shippingPoint.ShippingPointName,
                    Description = shippingPoint.Description,
                    PickupFee = _priceFormatter.FormatShippingPrice(shippingPoint.PickupFee, true),
                    OpeningHours = shippingPoint.OpeningHours,
                    Address1 = shippingPoint.Address1,
                    City = shippingPoint.City,
                    CountryName = (await _countryService.GetCountryById(shippingPoint.CountryId))?.Name,
                    ZipPostalCode = shippingPoint.ZipPostalCode,
                };
                return View("~/Plugins/Shipping.ShippingPoint/Views/FormShippingOption.cshtml", viewModel);
            }
            return Content("ShippingPointController: given Shipping Option doesn't exist");
        }
    }
}
