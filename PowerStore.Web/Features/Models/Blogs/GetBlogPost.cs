using PowerStore.Domain.Blogs;
using PowerStore.Web.Models.Blogs;
using MediatR;

namespace PowerStore.Web.Features.Models.Blogs
{
    public class GetBlogPost : IRequest<BlogPostModel>
    {
        public BlogPost BlogPost { get; set; }
    }
}
