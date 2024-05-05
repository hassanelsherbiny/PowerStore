using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;

namespace PowerStore.Services.Commands.Models.Messages
{
    public class GetGiftCardTokensCommand : IRequest<LiquidGiftCard>
    {
        public GiftCard GiftCard { get; set; }
        public Language Language { get; set; }
    }
}
