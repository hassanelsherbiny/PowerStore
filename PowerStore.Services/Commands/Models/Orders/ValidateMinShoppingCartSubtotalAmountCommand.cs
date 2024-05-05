using PowerStore.Domain.Customers;
using PowerStore.Domain.Orders;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerStore.Services.Commands.Models.Orders
{
    public class ValidateMinShoppingCartSubtotalAmountCommand : IRequest<bool>
    {
        public Customer Customer { get; set; }
        public IList<ShoppingCartItem> Cart { get; set; }
    }
}
