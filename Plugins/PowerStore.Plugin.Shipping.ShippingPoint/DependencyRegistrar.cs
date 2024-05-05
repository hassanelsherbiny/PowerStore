using PowerStore.Core.Configuration;
using PowerStore.Core.DependencyInjection;
using PowerStore.Core.TypeFinders;
using PowerStore.Plugin.Shipping.ShippingPoint.Services;
using Microsoft.Extensions.DependencyInjection;

namespace PowerStore.Plugin.Shipping.ShippingPoint
{
    public class DependencyInjection : IDependencyInjection
    {
        public virtual void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, PowerStoreConfig config)
        {
            serviceCollection.AddScoped<ShippingPointComputationMethod>();
            serviceCollection.AddScoped<IShippingPointService, ShippingPointService>();
        }

        public int Order {
            get { return 10; }
        }
    }
}
