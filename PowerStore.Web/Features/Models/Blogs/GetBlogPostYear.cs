using PowerStore.Web.Models.Blogs;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Blogs
{
    public class GetBlogPostYear : IRequest<IList<BlogPostYearModel>>
    {
    }
}
