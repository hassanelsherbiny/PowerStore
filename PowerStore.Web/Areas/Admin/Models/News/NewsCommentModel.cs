using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;

namespace PowerStore.Web.Areas.Admin.Models.News
{
    public partial class NewsCommentModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.NewsItem")]
        public string NewsItemId { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.NewsItem")]
        
        public string NewsItemTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.Customer")]
        public string CustomerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.Customer")]
        public string CustomerInfo { get; set; }

        
        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.CommentTitle")]
        public string CommentTitle { get; set; }

        
        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.CommentText")]
        public string CommentText { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

    }
}