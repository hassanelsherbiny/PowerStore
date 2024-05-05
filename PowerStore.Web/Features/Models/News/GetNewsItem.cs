using PowerStore.Domain.News;
using PowerStore.Web.Models.News;
using MediatR;

namespace PowerStore.Web.Features.Models.News
{
    public class GetNewsItem : IRequest<NewsItemModel>
    {
        public NewsItem NewsItem { get; set; }
    }
}
