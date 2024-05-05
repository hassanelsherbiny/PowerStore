using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;

namespace PowerStore.Web.Areas.Admin.Models.Catalog
{
    public partial class ProductReviewModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Product")]
        public string ProductId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Product")]
        public string ProductName { get; set; }

        public string Ids {
            get {
                return Id + ":" + ProductId;
            }
        }

        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Store")]
        public string StoreName { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Customer")]
        public string CustomerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Customer")]
        public string CustomerInfo { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Title")]
        public string Title { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.ReviewText")]
        public string ReviewText { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.ReplyText")]
        public string ReplyText { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Signature")]
        public string Signature { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Rating")]
        public int Rating { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.IsApproved")]
        public bool IsApproved { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
    }
}