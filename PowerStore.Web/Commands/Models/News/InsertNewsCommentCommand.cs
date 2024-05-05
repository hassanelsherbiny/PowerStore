using PowerStore.Domain.News;
using PowerStore.Web.Models.News;
using MediatR;

namespace PowerStore.Web.Commands.Models.News
{
    public class InsertNewsCommentCommand : IRequest<NewsComment>
    {
        public NewsItem NewsItem { get; set; }
        public NewsItemModel Model { get; set; }
    }
}
