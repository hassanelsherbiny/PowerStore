using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Knowledgebase
{
    public partial class AddKnowledgebaseArticleCommentModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Knowledgebase.Article.CommentText")]
        public string CommentText { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}
