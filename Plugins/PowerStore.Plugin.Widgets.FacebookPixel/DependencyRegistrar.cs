using PowerStore.Core.Configuration;
using PowerStore.Core.DependencyInjection;
using PowerStore.Core.Plugins;
using PowerStore.Core.TypeFinders;
using PowerStore.Services.Common;
using Microsoft.Extensions.DependencyInjection;

namespace PowerStore.Plugin.Widgets.FacebookPixel
{
    public class DependencyInjection : IDependencyInjection
    {
        public virtual void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, PowerStoreConfig config)
        {
            serviceCollection.AddScoped<FacebookPixelPlugin>();
            if (PluginManager.FindPlugin(GetType()).Installed)
            {
                serviceCollection.AddScoped<IConsentCookie, FacebookPixelConsentCookie>();
            }
        }

        public int Order {
            get { return 10; }
        }
    }

}
