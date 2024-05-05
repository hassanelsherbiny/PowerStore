using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Knowledgebase
{
    public class KnowledgebaseRelatedArticleGridModel : BaseEntityModel
    {
        public string Article2Name { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public string Article2Id { get; set; }
    }
}
