using PowerStore.Domain.Localization;
using PowerStore.Domain.Vendors;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;

namespace PowerStore.Services.Commands.Models.Messages
{
    public class GetVendorTokensCommand : IRequest<LiquidVendor>
    {
        public Vendor Vendor { get; set; }
        public Language Language { get; set; }
    }
}
