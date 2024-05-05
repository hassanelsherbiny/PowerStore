using PowerStore.Domain.Stores;
using PowerStore.Web.Areas.Admin.Models.Stores;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Interfaces
{
    public interface IStoreViewModelService
    {
        Task PrepareLanguagesModel(StoreModel model);
        Task PrepareWarehouseModel(StoreModel model);
        Task PrepareCountryModel(StoreModel model);
        Task PrepareCurrencyModel(StoreModel model);
        StoreModel PrepareStoreModel();
        Task<Store> InsertStoreModel(StoreModel model);
        Task<Store> UpdateStoreModel(Store store, StoreModel model);
        Task DeleteStore(Store store);

    }
}
