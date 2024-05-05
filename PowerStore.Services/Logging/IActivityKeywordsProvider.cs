using System.Collections.Generic;

namespace PowerStore.Services.Logging
{
    public partial interface IActivityKeywordsProvider
    {
        IList<string> GetCategorySystemKeywords();
        IList<string> GetProductSystemKeywords();
        IList<string> GetManufacturerSystemKeywords();
        IList<string> GetKnowledgebaseCategorySystemKeywords();
        IList<string> GetKnowledgebaseArticleSystemKeywords();
    }
}
