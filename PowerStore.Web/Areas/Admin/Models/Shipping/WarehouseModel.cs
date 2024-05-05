using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using PowerStore.Web.Areas.Admin.Models.Common;

namespace PowerStore.Web.Areas.Admin.Models.Shipping
{
    public partial class WarehouseModel : BaseEntityModel
    {
        public WarehouseModel()
        {
            Address = new AddressModel();
        }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.AdminComment")]
        public string AdminComment { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.Latitude")]
        public double? Latitude { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.Longitude")]
        public double? Longitude { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.Address")]
        public AddressModel Address { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}