using PowerStore.Domain.Catalog;
using PowerStore.Domain.Localization;
using MediatR;

namespace PowerStore.Services.Commands.Models.Catalog
{
    public class SendOutBidCustomerNotificationCommand : IRequest<bool>
    {
        public Product Product { get; set; }
        public Bid Bid { get; set; }
        public Language Language { get; set; }
    }
}
