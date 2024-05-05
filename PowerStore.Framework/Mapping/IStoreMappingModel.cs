using PowerStore.Core.ModelBinding;
using PowerStore.Framework.Mvc.Models;
using System.Collections.Generic;

namespace PowerStore.Framework.Mapping
{
    public interface IStoreMappingModel
    {
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.LimitedToStores")]
        bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.AvailableStores")]
        List<StoreModel> AvailableStores { get; set; }
        string[] SelectedStoreIds { get; set; }
    }
}
