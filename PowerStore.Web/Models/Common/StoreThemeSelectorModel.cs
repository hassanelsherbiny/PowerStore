using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Common
{
    public partial class StoreThemeSelectorModel : BaseModel
    {
        public StoreThemeSelectorModel()
        {
            AvailableStoreThemes = new List<StoreThemeModel>();
        }

        public IList<StoreThemeModel> AvailableStoreThemes { get; set; }

        public StoreThemeModel CurrentStoreTheme { get; set; }
    }
}