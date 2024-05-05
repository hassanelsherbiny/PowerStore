using PowerStore.Domain.Customers;
using System.Threading.Tasks;

namespace PowerStore.Services.Authentication
{
    public partial interface IApiAuthenticationService
    {
        /// <summary>
        /// Get authenticated customer
        /// </summary>
        /// <returns>Customer</returns>
        Task<Customer> GetAuthenticatedCustomer();
    }
}
