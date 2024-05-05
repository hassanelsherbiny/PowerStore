using PowerStore.Domain.Directory;
using PowerStore.Web.Areas.Admin.Models.Directory;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Interfaces
{
    public interface ICountryViewModelService
    {
        CountryModel PrepareCountryModel();
        Task<Country> InsertCountryModel(CountryModel model);
        Task<Country> UpdateCountryModel(Country country, CountryModel model);
        StateProvinceModel PrepareStateProvinceModel(string countryId);
        Task<StateProvince> InsertStateProvinceModel(StateProvinceModel model);
        Task<StateProvince> UpdateStateProvinceModel(StateProvince sp, StateProvinceModel model);
    }
}
