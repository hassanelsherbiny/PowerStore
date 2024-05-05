using PowerStore.Core.Mapper;
using PowerStore.Domain.Catalog;
using PowerStore.Web.Areas.Admin.Models.Catalog;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class ProductReviewMappingExtensions
    {
        public static ProductReview ToEntity(this ProductReviewModel model, ProductReview destination)
        {
            return model.MapTo(destination);
        }
    }
}