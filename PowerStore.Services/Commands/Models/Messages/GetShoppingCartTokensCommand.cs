using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;
namespace PowerStore.Services.Commands.Models.Messages
{
    public class GetShoppingCartTokensCommand : IRequest<LiquidShoppingCart>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
        public string PersonalMessage { get; set; } = "";
        public string CustomerEmail { get; set; } = "";
    }
}
