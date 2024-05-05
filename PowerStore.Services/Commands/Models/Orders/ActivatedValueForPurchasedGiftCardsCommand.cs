using PowerStore.Domain.Orders;
using MediatR;

namespace PowerStore.Services.Commands.Models.Orders
{
    public class ActivatedValueForPurchasedGiftCardsCommand : IRequest<bool>
    {
        public Order Order { get; set; }
        public bool Activate { get; set; }
    }
}
