using PowerStore.Services.Catalog;
using PowerStore.Services.Commands.Models.Messages;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Services.Commands.Handlers.Messages
{
    public class GetGiftCardTokensCommandHandler : IRequestHandler<GetGiftCardTokensCommand, LiquidGiftCard>
    {
        private readonly IPriceFormatter _priceFormatter;

        public GetGiftCardTokensCommandHandler(IPriceFormatter priceFormatter)
        {
            _priceFormatter = priceFormatter;
        }

        public async Task<LiquidGiftCard> Handle(GetGiftCardTokensCommand request, CancellationToken cancellationToken)
        {
            var liquidGiftCart = new LiquidGiftCard(request.GiftCard) {
                Amount = await _priceFormatter.FormatPrice(request.GiftCard.Amount, true, request.GiftCard.CurrencyCode, false, request.Language)
            };
            return await Task.FromResult(liquidGiftCart);
        }
    }
}
