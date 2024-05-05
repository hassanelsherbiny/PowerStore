using PowerStore.Domain.Orders;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Checkout
{
    public class GetIsPaymentWorkflowRequired : IRequest<bool>
    {
        public IList<ShoppingCartItem> Cart { get; set; }
        public bool? UseRewardPoints { get; set; } = null;
    }
}
