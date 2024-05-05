using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Checkout;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Checkout
{
    public class GetShippingMethod : IRequest<CheckoutShippingMethodModel>
    {
        public IList<ShoppingCartItem> Cart { get; set; }
        public Address ShippingAddress { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Currency Currency { get; set; }
        public Language Language { get; set; }

    }
}
