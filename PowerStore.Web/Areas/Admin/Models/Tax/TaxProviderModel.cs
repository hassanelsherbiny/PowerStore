using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Tax
{
    public partial class TaxProviderModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Tax.Providers.Fields.FriendlyName")]
        
        public string FriendlyName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Tax.Providers.Fields.SystemName")]
        
        public string SystemName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Tax.Providers.Fields.IsPrimaryTaxProvider")]
        public bool IsPrimaryTaxProvider { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Tax.Providers.Fields.Configure")]
        public string ConfigurationUrl { get; set; }
    }
}