using PowerStore.Domain.Customers;
using PowerStore.Domain.Orders;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Services.Commands.Models.Orders
{
    public class ValidateShoppingCartTotalAmountCommand : IRequest<bool>
    {
        public Customer Customer { get; set; }
        public IList<ShoppingCartItem> Cart { get; set; }
    }
}
