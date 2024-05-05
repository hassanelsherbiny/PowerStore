using PowerStore.Core.Models;
using PowerStore.Web.Areas.Admin.Models.Localization;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Common
{
    public partial class LanguageSelectorModel : BaseModel
    {
        public LanguageSelectorModel()
        {
            AvailableLanguages = new List<LanguageModel>();
        }

        public IList<LanguageModel> AvailableLanguages { get; set; }

        public LanguageModel CurrentLanguage { get; set; }
    }
}