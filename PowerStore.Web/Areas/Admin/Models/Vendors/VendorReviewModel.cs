using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;

namespace PowerStore.Web.Areas.Admin.Models.Vendors
{
    public partial class VendorReviewModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.VendorReviews.Fields.Vendor")]
        public string VendorId { get; set; }
        [PowerStoreResourceDisplayName("Admin.VendorReviews.Fields.Vendor")]
        public string VendorName { get; set; }

        public string Ids {
            get {
                return Id.ToString() + ":" + VendorId;
            }
        }
        [PowerStoreResourceDisplayName("Admin.VendorReviews.Fields.Customer")]
        public string CustomerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.VendorReviews.Fields.Customer")]
        public string CustomerInfo { get; set; }

        [PowerStoreResourceDisplayName("Admin.VendorReviews.Fields.Title")]
        public string Title { get; set; }

        [PowerStoreResourceDisplayName("Admin.VendorReviews.Fields.ReviewText")]
        public string ReviewText { get; set; }

        [PowerStoreResourceDisplayName("Admin.VendorReviews.Fields.Rating")]
        public int Rating { get; set; }

        [PowerStoreResourceDisplayName("Admin.VendorReviews.Fields.IsApproved")]
        public bool IsApproved { get; set; }

        [PowerStoreResourceDisplayName("Admin.VendorReviews.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
    }
}
