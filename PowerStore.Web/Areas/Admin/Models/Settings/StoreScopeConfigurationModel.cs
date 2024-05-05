using PowerStore.Core.Models;
using PowerStore.Framework.Mvc.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Settings
{
    public partial class StoreScopeConfigurationModel : BaseModel
    {
        public StoreScopeConfigurationModel()
        {
            Stores = new List<StoreModel>();
        }

        public string StoreId { get; set; }
        public IList<StoreModel> Stores { get; set; }
    }
}