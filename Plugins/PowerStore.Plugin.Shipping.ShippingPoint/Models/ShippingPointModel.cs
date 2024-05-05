using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Plugin.Shipping.ShippingPoint.Models
{
    public class ShippingPointModel : BaseEntityModel
    {
        public ShippingPointModel()
        {
            AvailableCountries = new List<SelectListItem>();
            AvailableStores = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Plugins.Shipping.ShippingPoint.Fields.ShippingPointName")]
        public string ShippingPointName { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Shipping.ShippingPoint.Fields.Description")]
        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Shipping.ShippingPoint.Fields.OpeningHours")]
        public string OpeningHours { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Shipping.ShippingPoint.Fields.PickupFee")]
        public decimal PickupFee { get; set; }


        public List<SelectListItem> AvailableStores { get; set; }
        [PowerStoreResourceDisplayName("Plugins.Shipping.ShippingPoint.Fields.Store")]
        public string StoreId { get; set; }

        public string StoreName { get; set; }


        [PowerStoreResourceDisplayName("Plugins.Shipping.ShippingPoint.Fields.City")]
        public string City { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Shipping.ShippingPoint.Fields.Address1")]
        public string Address1 { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Shipping.ShippingPoint.Fields.ZipPostalCode")]
        public string ZipPostalCode { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Shipping.ShippingPoint.Fields.Country")]
        public string CountryId { get; set; }

        public IList<SelectListItem> AvailableCountries { get; set; }
    }


}