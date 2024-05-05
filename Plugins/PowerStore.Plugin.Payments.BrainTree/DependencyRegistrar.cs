using PowerStore.Core.Configuration;
using PowerStore.Core.DependencyInjection;
using PowerStore.Core.TypeFinders;
using Microsoft.Extensions.DependencyInjection;

namespace PowerStore.Plugin.Payments.BrainTree
{
    public class DependencyInjection : IDependencyInjection
    {
        public virtual void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, PowerStoreConfig config)
        {
            serviceCollection.AddScoped<BrainTreePaymentProcessor>();
        }

        public int Order {
            get { return 10; }
        }
    }

}
