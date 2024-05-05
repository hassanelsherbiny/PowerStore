using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Stores;
using PowerStore.Domain.Tax;
using PowerStore.Web.Models.ShoppingCart;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.ShoppingCart
{
    public class GetOrderTotals : IRequest<OrderTotalsModel>
    {
        public Customer Customer { get; set; }
        public Language Language { get; set; }
        public Currency Currency { get; set; }
        public Store Store { get; set; }
        public TaxDisplayType TaxDisplayType { get; set; }
        public IList<ShoppingCartItem> Cart { get; set; }
        public bool IsEditable { get; set; }
    }
}
