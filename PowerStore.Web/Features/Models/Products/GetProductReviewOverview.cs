using PowerStore.Domain.Catalog;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Catalog;
using MediatR;

namespace PowerStore.Web.Features.Models.Products
{
    public class GetProductReviewOverview : IRequest<ProductReviewOverviewModel>
    {
        public Product Product { get; set; }
        public Language Language { get; set; }
        public Store Store { get; set; }
    }
}
