using PowerStore.Domain.Catalog;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Catalog;
using MediatR;

namespace PowerStore.Web.Commands.Models.Products
{
    public class InsertProductReviewCommand : IRequest<ProductReview>
    {
        public Store Store { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public ProductReviewsModel Model { get; set; }
    }
}
