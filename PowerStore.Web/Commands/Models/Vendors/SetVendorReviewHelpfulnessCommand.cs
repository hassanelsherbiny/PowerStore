using PowerStore.Domain.Customers;
using PowerStore.Domain.Vendors;
using MediatR;

namespace PowerStore.Web.Commands.Models.Vendors
{
    public class SetVendorReviewHelpfulnessCommand : IRequest<VendorReview>
    {
        public Customer Customer { get; set; }
        public Vendor Vendor { get; set; }
        public VendorReview Review { get; set; }
        public bool Washelpful { get; set; }
    }
}
