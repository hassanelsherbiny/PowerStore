
using PowerStore.Domain.Configuration;

namespace PowerStore.Plugin.Shipping.ByWeight
{
    public class ShippingByWeightSettings : ISettings
    {
        public bool LimitMethodsToCreated { get; set; }
    }
}