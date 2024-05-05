using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Stores;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PowerStore.Web.Commands.Models.ShoppingCart
{
    public class SaveCheckoutAttributesCommand : IRequest<IList<CustomAttribute>>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }

        public IList<ShoppingCartItem> Cart { get; set; }
        public IFormCollection Form { get; set; }
    }
}
