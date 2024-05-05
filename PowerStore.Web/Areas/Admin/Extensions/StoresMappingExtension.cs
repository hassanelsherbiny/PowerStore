using PowerStore.Domain.Stores;
using PowerStore.Framework.Mapping;
using PowerStore.Core.Models;
using PowerStore.Services.Stores;
using System.Linq;
using System.Threading.Tasks;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class StoresMappingExtension
    {
        public static async Task PrepareStoresMappingModel<T>(this T basePowerStoreEntityModel, IStoreMappingSupported storeMapping, IStoreService _storeService, bool excludeProperties, string storeId = null) 
            where T : BaseEntityModel, IStoreMappingModel
        {
            basePowerStoreEntityModel.AvailableStores = (await _storeService
               .GetAllStores()).Where(x=>x.Id == storeId || string.IsNullOrEmpty(storeId))
               .Select(s => new StoreModel { Id = s.Id, Name = s.Shortcut })
               .ToList();
            if (!excludeProperties)
            {
                if (storeMapping != null)
                {
                    basePowerStoreEntityModel.SelectedStoreIds = storeMapping.Stores.ToArray();
                }
            }
            if (!string.IsNullOrEmpty(storeId))
            {
                basePowerStoreEntityModel.LimitedToStores = true;
                basePowerStoreEntityModel.SelectedStoreIds = new string[] { storeId };
            }
        }       
    }
}
