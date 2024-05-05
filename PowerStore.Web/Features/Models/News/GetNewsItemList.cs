using PowerStore.Web.Models.News;
using MediatR;

namespace PowerStore.Web.Features.Models.News
{
    public class GetNewsItemList : IRequest<NewsItemListModel>
    {
        public NewsPagingFilteringModel Command { get; set; }
    }
}
