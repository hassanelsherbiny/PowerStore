using PowerStore.Web.Models.Blogs;
using MediatR;

namespace PowerStore.Web.Features.Models.Blogs
{
    public class GetBlogPostList: IRequest<BlogPostListModel>
    {
        public GetBlogPostList()
        {
            Command = new BlogPagingFilteringModel();
        }
        public BlogPagingFilteringModel Command { get; set; }
    }
}
