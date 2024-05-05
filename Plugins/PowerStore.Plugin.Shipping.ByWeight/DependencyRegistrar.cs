using PowerStore.Core.Configuration;
using PowerStore.Core.DependencyInjection;
using PowerStore.Core.TypeFinders;
using PowerStore.Plugin.Shipping.ByWeight.Controllers;
using PowerStore.Plugin.Shipping.ByWeight.Services;
using Microsoft.Extensions.DependencyInjection;

namespace PowerStore.Plugin.Shipping.ByWeight
{
    public class DependencyInjection : IDependencyInjection
    {
        public virtual void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, PowerStoreConfig config)
        {
            serviceCollection.AddScoped<IShippingByWeightService, ShippingByWeightService>();
            //base shipping controller
            serviceCollection.AddScoped<ShippingByWeightController>();
            serviceCollection.AddScoped<ByWeightShippingComputationMethod>();
        }

        public int Order {
            get { return 10; }
        }
    }
}
