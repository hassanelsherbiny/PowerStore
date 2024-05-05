using PowerStore.Domain.Customers;
using PowerStore.Domain.Orders;
using PowerStore.Web.Models.Checkout;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Checkout
{
    public class GetConfirmOrder : IRequest<CheckoutConfirmModel>
    {
        public Customer Customer { get; set; }
        public IList<ShoppingCartItem> Cart { get; set; }
    }
}
