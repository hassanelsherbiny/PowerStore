using PowerStore.Domain.Catalog;
using PowerStore.Web.Models.Catalog;
using MediatR;

namespace PowerStore.Web.Events
{
    public class ProductReviewEvent : INotification
    {
        public Product Product { get; private set; }
        public AddProductReviewModel ProductReview { get; private set; }
        public ProductReviewEvent(Product product, AddProductReviewModel productReview)
        {
            Product = product;
            ProductReview = productReview;
        }
    }
}
