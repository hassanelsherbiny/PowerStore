using PowerStore.Core.Configuration;
using PowerStore.Core.DependencyInjection;
using PowerStore.Core.TypeFinders;
using PowerStore.Plugin.DiscountRequirements.CustomerRoles;
using PowerStore.Plugin.DiscountRequirements.HasAllProducts;
using PowerStore.Plugin.DiscountRequirements.HasOneProduct;
using PowerStore.Plugin.DiscountRequirements.ShoppingCart;
using PowerStore.Plugin.DiscountRequirements.Standard.HadSpentAmount;
using Microsoft.Extensions.DependencyInjection;

namespace PowerStore.Plugin.DiscountRequirements.Standard
{
    public class DependencyInjection : IDependencyInjection
    {
        public virtual void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, PowerStoreConfig config)
        {
            serviceCollection.AddScoped<DiscountRequirementsPlugin>();
            serviceCollection.AddScoped<CustomerRoleDiscountRequirementRule>();
            serviceCollection.AddScoped<HadSpentAmountDiscountRequirementRule>();
            serviceCollection.AddScoped<HasAllProductsDiscountRequirementRule>();
            serviceCollection.AddScoped<HasOneProductDiscountRequirementRule>();
            serviceCollection.AddScoped<ShoppingCartDiscountRequirementRule>();
        }

        public int Order {
            get { return 10; }
        }
    }
}
