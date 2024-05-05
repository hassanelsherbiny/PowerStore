using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;

namespace PowerStore.Web.Areas.Admin.Models.Blogs
{
    public partial class BlogCommentModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.BlogPost")]
        public string BlogPostId { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.BlogPost")]
        
        public string BlogPostTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.Customer")]
        public string CustomerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.Customer")]
        public string CustomerInfo { get; set; }

        
        [PowerStoreResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.Comment")]
        public string Comment { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

    }
}