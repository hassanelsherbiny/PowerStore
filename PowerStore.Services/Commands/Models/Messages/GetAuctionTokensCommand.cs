using PowerStore.Domain.Catalog;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;

namespace PowerStore.Services.Commands.Models.Messages
{
    public class GetAuctionTokensCommand : IRequest<LiquidAuctions>
    {
        public Product Product { get; set; }
        public Bid Bid { get; set; }
    }
}
