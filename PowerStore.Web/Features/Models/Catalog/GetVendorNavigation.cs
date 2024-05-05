using PowerStore.Domain.Localization;
using PowerStore.Web.Models.Catalog;
using MediatR;

namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetVendorNavigation : IRequest<VendorNavigationModel>
    {
        public Language Language { get; set; }
    }
}
