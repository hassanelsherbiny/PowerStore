using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Plugin.ExchangeRate.McExchange
{
    internal interface IRateProvider
    {
        Task<IList<Domain.Directory.ExchangeRate>> GetCurrencyLiveRates();
    }
}
