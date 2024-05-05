using PowerStore.Core;
using PowerStore.Core.Configuration;
using PowerStore.Core.Data;
using PowerStore.Framework.Infrastructure.Extensions;
using PowerStore.Framework.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PowerStore.Framework.StartupConfigure
{
    /// <summary>
    /// Represents object for the configuring authentication middleware on application startup
    /// </summary>
    public class AuthenticationStartup : IPowerStoreStartup
    {
        /// <summary>
        /// Add and configure any of the middleware
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration root of the application</param>
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var config = new PowerStoreConfig();
            configuration.GetSection("PowerStore").Bind(config);

            //add data protection
            services.AddPowerStoreDataProtection(config);
            //add authentication
            services.AddPowerStoreAuthentication(configuration);
        }

        /// <summary>
        /// Configure the using of added middleware
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        public void Configure(IApplicationBuilder application, IWebHostEnvironment webHostEnvironment)
        {
            //check whether database is installed
            if (!DataSettingsHelper.DatabaseIsInstalled())
                return;

            //configure authentication
            application.UsePowerStoreAuthentication();

            //set storecontext
            application.UseMiddleware<StoreContextMiddleware>();

            //set workcontext
            application.UseMiddleware<WorkContextMiddleware>();

        }

        /// <summary>
        /// Gets order of this startup configuration implementation
        /// </summary>
        public int Order {
            //authentication should be loaded before MVC
            get { return 500; }
        }
    }
}
