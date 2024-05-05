using PowerStore.Core.Models;
using System;

namespace PowerStore.Web.Models.News
{
    public partial class NewsCommentModel : BaseEntityModel
    {
        public string CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CommentTitle { get; set; }

        public string CommentText { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}