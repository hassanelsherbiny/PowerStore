using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Domain.Tax;
using PowerStore.Web.Models.ShoppingCart;
using MediatR;

namespace PowerStore.Web.Features.Models.ShoppingCart
{
    public class GetMiniShoppingCart : IRequest<MiniShoppingCartModel>
    {
        public Customer Customer { get; set; }
        public Language Language { get; set; }
        public Currency Currency { get; set; }
        public Store Store { get; set; }
        public TaxDisplayType TaxDisplayType { get; set; }
    }
}
