using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Shipping;
using PowerStore.Domain.Stores;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;

namespace PowerStore.Services.Commands.Models.Messages
{
    public class GetShipmentTokensCommand : IRequest<LiquidShipment>
    {
        public Shipment Shipment { get; set; }
        public Order Order { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
    }
}
