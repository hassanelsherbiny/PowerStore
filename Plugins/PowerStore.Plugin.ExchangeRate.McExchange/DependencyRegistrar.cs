using PowerStore.Core.Configuration;
using PowerStore.Core.DependencyInjection;
using PowerStore.Core.TypeFinders;
using PowerStore.Plugin.ExchangeRate.McExchange;
using Microsoft.Extensions.DependencyInjection;

namespace PowerStore.Plugin.ExchangeRate.EcbExchange
{
    public class DependencyInjection : IDependencyInjection
    {
        public virtual void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, PowerStoreConfig config)
        {
            serviceCollection.AddScoped<McExchangeRateProvider>();
        }

        public int Order {
            get { return 10; }
        }
    }
}
