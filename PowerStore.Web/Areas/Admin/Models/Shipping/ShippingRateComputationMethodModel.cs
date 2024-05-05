using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Shipping
{
    public partial class ShippingRateComputationMethodModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.FriendlyName")]
        
        public string FriendlyName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.SystemName")]
        
        public string SystemName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.IsActive")]
        public bool IsActive { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.Logo")]
        public string LogoUrl { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Shipping.Providers.Configure")]
        public string ConfigurationUrl { get; set; }
    }
}