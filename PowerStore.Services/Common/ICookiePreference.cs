using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Services.Common
{
    public interface ICookiePreference
    {
        IList<IConsentCookie> GetConsentCookies();
        Task<bool?> IsEnable(Customer customer, Store store, string cookieSystemName);
    }
}
