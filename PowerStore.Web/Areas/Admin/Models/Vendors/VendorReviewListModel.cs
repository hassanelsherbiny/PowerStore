using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class VendorReviewListModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.VendorReviews.List.CreatedOnFrom")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnFrom { get; set; }

        [PowerStoreResourceDisplayName("Admin.VendorReviews.List.CreatedOnTo")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnTo { get; set; }

        [PowerStoreResourceDisplayName("Admin.VendorReviews.List.SearchText")]
        public string SearchText { get; set; }

        [PowerStoreResourceDisplayName("Admin.VendorReviews.List.SearchVendor")]
        public string SearchVendorId { get; set; }

    }
}