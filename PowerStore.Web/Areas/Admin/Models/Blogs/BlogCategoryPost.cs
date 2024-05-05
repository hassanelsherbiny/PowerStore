using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Blogs
{
    public class BlogCategoryPost : BaseEntityModel
    {
        public string BlogPostId { get; set; }
        public string Name { get; set; }
    }
}
