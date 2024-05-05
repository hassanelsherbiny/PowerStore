using PowerStore.Domain.Catalog;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;

namespace PowerStore.Services.Commands.Models.Messages
{
    public class GetAttributeCombinationTokensCommand : IRequest<LiquidAttributeCombination>
    {
        public Product Product { get; set; }
        public ProductAttributeCombination Combination { get; set; }
    }
}
