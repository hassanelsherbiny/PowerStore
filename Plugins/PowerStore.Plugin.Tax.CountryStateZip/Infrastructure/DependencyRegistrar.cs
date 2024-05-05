using PowerStore.Core.Configuration;
using PowerStore.Core.DependencyInjection;
using PowerStore.Core.TypeFinders;
using PowerStore.Plugin.Tax.CountryStateZip.Services;
using Microsoft.Extensions.DependencyInjection;

namespace PowerStore.Plugin.Tax.CountryStateZip.Infrastructure
{
    public class DependencyInjection : IDependencyInjection
    {
        public virtual void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, PowerStoreConfig config)
        {
            serviceCollection.AddScoped<ITaxRateService, TaxRateService>();
            serviceCollection.AddScoped<CountryStateZipTaxProvider>();
        }

        public int Order {
            get { return 20; }
        }
    }
}
