using PowerStore.Domain.Directory;
using PowerStore.Services.Directory;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Interfaces;
using PowerStore.Web.Areas.Admin.Models.Directory;
using System;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Services
{
    public partial class CurrencyViewModelService : ICurrencyViewModelService
    {
        #region Fields

        private readonly ICurrencyService _currencyService;

        #endregion

        #region Constructors

        public CurrencyViewModelService(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        #endregion

        public virtual CurrencyModel PrepareCurrencyModel()
        {
            var model = new CurrencyModel();
            //default values
            model.Published = true;
            model.Rate = 1;
            return model;
        }

        public virtual async Task<Currency> InsertCurrencyModel(CurrencyModel model)
        {
            var currency = model.ToEntity();
            currency.CreatedOnUtc = DateTime.UtcNow;
            currency.UpdatedOnUtc = DateTime.UtcNow;
            await _currencyService.InsertCurrency(currency);

            return currency;
        }

        public virtual async Task<Currency> UpdateCurrencyModel(Currency currency, CurrencyModel model)
        {
            currency = model.ToEntity(currency);
            currency.UpdatedOnUtc = DateTime.UtcNow;
            await _currencyService.UpdateCurrency(currency);
            return currency;
        }
    }
}
