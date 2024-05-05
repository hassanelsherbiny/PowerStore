using PowerStore.Core.ModelBinding;

namespace PowerStore.Plugin.Shipping.FixedRateShipping.Models
{
    public class FixedShippingRateModel
    {
        public string ShippingMethodId { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Shipping.FixedRateShipping.Fields.ShippingMethodName")]
        public string ShippingMethodName { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Shipping.FixedRateShipping.Fields.Rate")]
        public decimal Rate { get; set; }
    }
}