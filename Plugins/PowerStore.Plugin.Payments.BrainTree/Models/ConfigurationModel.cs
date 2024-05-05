using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Plugin.Payments.BrainTree.Models
{
    public class ConfigurationModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Plugins.Payments.BrainTree.Fields.Use3DS")]
        public bool Use3DS { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Payments.BrainTree.Fields.UseSandbox")]
        public bool UseSandBox { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Payments.BrainTree.Fields.MerchantId")]
        public string MerchantId { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Payments.BrainTree.Fields.PublicKey")]
        public string PublicKey { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Payments.BrainTree.Fields.PrivateKey")]
        public string PrivateKey { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Payments.BrainTree.Fields.AdditionalFee")]
        public decimal AdditionalFee { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Payments.BrainTree.Fields.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
    }
}