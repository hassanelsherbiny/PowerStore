using PowerStore.Domain.Blogs;
using PowerStore.Web.Models.Blogs;
using MediatR;

namespace PowerStore.Web.Events
{
    public class BlogCommentEvent : INotification
    {
        public BlogPost BlogPost { get; private set; }
        public AddBlogCommentModel BlogComment { get; private set; }
        public BlogCommentEvent(BlogPost blogPost, AddBlogCommentModel blogComment)
        {
            BlogPost = blogPost;
            BlogComment = blogComment;
        }
    }
}
