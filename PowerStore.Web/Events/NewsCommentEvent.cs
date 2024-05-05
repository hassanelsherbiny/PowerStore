using PowerStore.Domain.News;
using PowerStore.Web.Models.News;
using MediatR;

namespace PowerStore.Web.Events
{
    public class NewsCommentEvent : INotification
    {
        public NewsItem News { get; private set; }
        public AddNewsCommentModel NewsComment { get; private set; }
        public NewsCommentEvent(NewsItem news, AddNewsCommentModel newsComment)
        {
            News = news;
            NewsComment = newsComment;
        }
    }
}
