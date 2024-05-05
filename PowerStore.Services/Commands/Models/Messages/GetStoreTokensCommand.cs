using PowerStore.Domain.Localization;
using PowerStore.Domain.Messages;
using PowerStore.Domain.Stores;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;

namespace PowerStore.Services.Commands.Models.Messages
{
    public class GetStoreTokensCommand : IRequest<LiquidStore>
    {
        public Store Store { get; set; }
        public Language Language { get; set; }
        public EmailAccount EmailAccount { get; set; }
    }
}
