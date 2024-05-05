using PowerStore.Domain.Stores;
using PowerStore.Domain.Vendors;
using PowerStore.Web.Models.Vendors;
using MediatR;

namespace PowerStore.Web.Commands.Models.Vendors
{
    public class InsertVendorReviewCommand : IRequest<VendorReview>
    {
        public Vendor Vendor { get; set; }
        public Store Store { get; set; }
        public VendorReviewsModel Model { get; set; }
    }
}
