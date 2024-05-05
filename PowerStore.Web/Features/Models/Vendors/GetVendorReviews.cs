using PowerStore.Domain.Vendors;
using PowerStore.Web.Models.Vendors;
using MediatR;

namespace PowerStore.Web.Features.Models.Vendors
{
    public class GetVendorReviews : IRequest<VendorReviewsModel>
    {
        public Vendor Vendor { get; set; }
    }
}
