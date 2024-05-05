using PowerStore.Domain.Catalog;
using MediatR;

namespace PowerStore.Services.Notifications.Catalog
{
    /// <summary>
    /// Product review approved event
    /// </summary>
    public class ProductReviewApprovedEvent : INotification
    {
        public ProductReviewApprovedEvent(ProductReview productReview)
        {
            ProductReview = productReview;
        }

        /// <summary>
        /// Product review
        /// </summary>
        public ProductReview ProductReview { get; private set; }
    }
}