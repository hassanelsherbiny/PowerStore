using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using System.Threading.Tasks;

namespace PowerStore.Services.Authentication
{
    public interface ISMSVerificationService
    {
        Task<bool> Authenticate(string secretKey, string token, Customer customer);
        Task<TwoFactorCodeSetup> GenerateCode(string secretKey, Customer customer, Language language);
    }
}
