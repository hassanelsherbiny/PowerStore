using PowerStore.Domain.Catalog;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Discounts;
using PowerStore.Core.Plugins;
using System.Threading.Tasks;

namespace PowerStore.Services.Discounts
{
    public partial interface IDiscountAmountProvider : IPlugin
    {
        Task<decimal> DiscountAmount(Discount discount, Customer customer, Product product, decimal amount);
    }
}
