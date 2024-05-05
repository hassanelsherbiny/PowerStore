using PowerStore.Domain.Directory;
using PowerStore.Core.Plugins;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Services.Directory
{
    /// <summary>
    /// Exchange rate provider interface
    /// </summary>
    public partial interface IExchangeRateProvider : IPlugin
    {
        /// <summary>
        /// Gets currency live rates
        /// </summary>
        /// <param name="exchangeRateCurrencyCode">Exchange rate currency code</param>
        /// <returns>Exchange rates</returns>
        Task<IList<ExchangeRate>> GetCurrencyLiveRates(string exchangeRateCurrencyCode);
    }
}