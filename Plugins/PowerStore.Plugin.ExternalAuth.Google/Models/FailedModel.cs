using PowerStore.Core.Models;

namespace PowerStore.Plugin.ExternalAuth.Google.Models
{
    public class FailedModel : BaseModel
    {
        public string ErrorMessage { get; set; }
    }
}
