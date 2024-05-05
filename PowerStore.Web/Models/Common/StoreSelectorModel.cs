using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Common
{
    public partial class StoreSelectorModel : BaseModel
    {
        public StoreSelectorModel()
        {
            AvailableStores = new List<StoreModel>();
        }

        public IList<StoreModel> AvailableStores { get; set; }

        public string CurrentStoreId { get; set; }

    }
}