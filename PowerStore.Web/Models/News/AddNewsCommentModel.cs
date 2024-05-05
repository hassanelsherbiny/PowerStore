using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Models.News
{
    public partial class AddNewsCommentModel : BaseModel
    {
        [PowerStoreResourceDisplayName("News.Comments.CommentTitle")]
        public string CommentTitle { get; set; }

        [PowerStoreResourceDisplayName("News.Comments.CommentText")]
        public string CommentText { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}