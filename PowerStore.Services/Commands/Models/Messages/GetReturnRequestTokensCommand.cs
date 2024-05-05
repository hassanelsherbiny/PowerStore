using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Stores;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;

namespace PowerStore.Services.Commands.Models.Messages
{
    public class GetReturnRequestTokensCommand : IRequest<LiquidReturnRequest>
    {
        public ReturnRequest ReturnRequest { get; set; }
        public Store Store { get; set; }
        public Order Order { get; set; }
        public Language Language { get; set; }
        public ReturnRequestNote ReturnRequestNote { get; set; } = null;
    }
}
