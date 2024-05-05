using PowerStore.Core.Configuration;
using PowerStore.Core.TypeFinders;
using Microsoft.Extensions.DependencyInjection;

namespace PowerStore.Core.DependencyInjection
{
    /// <summary>
    /// Dependency registrar interface
    /// </summary>
    public interface IDependencyInjection
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="serviceCollection">Service Collection</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, PowerStoreConfig config);

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        int Order { get; }
    }
}
