using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Catalog;
using MediatR;

namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetPopularProductTags : IRequest<PopularProductTagsModel>
    {
        public Language Language { get; set; }
        public Store Store { get; set; }
    }
}
