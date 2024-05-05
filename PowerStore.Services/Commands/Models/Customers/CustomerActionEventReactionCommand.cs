using PowerStore.Domain.Customers;
using PowerStore.Domain.Orders;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Services.Commands.Models.Customers
{
    public class CustomerActionEventReactionCommand : IRequest<bool>
    {
        public CustomerActionEventReactionCommand()
        {
            CustomerActionTypes = new List<CustomerActionType>();
        }
        public IList<CustomerActionType> CustomerActionTypes { get; set; }
        public CustomerAction Action { get; set; }
        public ShoppingCartItem CartItem { get; set; }
        public Order Order { get; set; }
        public string CustomerId { get; set; }
    }
}
