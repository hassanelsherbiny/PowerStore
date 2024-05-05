using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Common
{
    public partial class LanguageSelectorModel : BaseModel
    {
        public LanguageSelectorModel()
        {
            AvailableLanguages = new List<LanguageModel>();
        }

        public IList<LanguageModel> AvailableLanguages { get; set; }

        public string CurrentLanguageId { get; set; }

        public bool UseImages { get; set; }
    }
}