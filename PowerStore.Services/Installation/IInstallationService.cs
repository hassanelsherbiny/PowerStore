using System.Threading.Tasks;

namespace PowerStore.Services.Installation
{
    public partial interface IInstallationService
    {
        Task InstallData(string defaultUserEmail, string defaultUserPassword, string collation, bool installSampleData = true, string companyName = "", string companyAddress = "", string companyPhoneNumber = "", string companyEmail = "");
    }
}
