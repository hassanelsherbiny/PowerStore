using PowerStore.Domain.Directory;
using PowerStore.Web.Areas.Admin.Models.Directory;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Interfaces
{
    public interface ICurrencyViewModelService
    {
        CurrencyModel PrepareCurrencyModel();
        Task<Currency> InsertCurrencyModel(CurrencyModel model);
        Task<Currency> UpdateCurrencyModel(Currency currency, CurrencyModel model);
    }
}
