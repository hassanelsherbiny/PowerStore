using System.Collections.Generic;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Checkout;
using MediatR;

namespace PowerStore.Web.Features.Models.Checkout
{
    public class GetPaymentMethod : IRequest<CheckoutPaymentMethodModel>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Currency Currency { get; set; }
        public Language Language { get; set; }
        public IList<ShoppingCartItem> Cart { get; set; } 
        public string FilterByCountryId { get; set; }
    }
}
