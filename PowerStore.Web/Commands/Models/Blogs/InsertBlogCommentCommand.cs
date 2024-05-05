using PowerStore.Domain.Blogs;
using PowerStore.Web.Models.Blogs;
using MediatR;

namespace PowerStore.Web.Commands.Models.Blogs
{
    public class InsertBlogCommentCommand : IRequest<BlogComment>
    {
        public BlogPostModel Model { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
