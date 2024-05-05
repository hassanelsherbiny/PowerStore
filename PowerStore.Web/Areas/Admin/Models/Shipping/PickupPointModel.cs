using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using PowerStore.Web.Areas.Admin.Models.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Shipping
{
    public partial class PickupPointModel : BaseEntityModel
    {
        public PickupPointModel()
        {
            this.Address = new AddressModel();
            this.AvailableWarehouses = new List<SelectListItem>();
            this.AvailableStores = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.PickupPoint.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.PickupPoint.Fields.Description")]

        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.PickupPoint.Fields.AdminComment")]

        public string AdminComment { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.PickupPoint.Fields.Address")]
        public AddressModel Address { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.PickupPoint.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.PickupPoint.Fields.Warehouses")]
        public IList<SelectListItem> AvailableWarehouses { get; set; }

        public string WarehouseId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.PickupPoint.Fields.Stores")]
        public IList<SelectListItem> AvailableStores { get; set; }
        public string StoreId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.PickupPoint.Fields.PickupFee")]
        public decimal PickupFee { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.PickupPoint.Fields.Latitude")]
        public double? Latitude { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.PickupPoint.Fields.Longitude")]
        public double? Longitude { get; set; }
    }
}