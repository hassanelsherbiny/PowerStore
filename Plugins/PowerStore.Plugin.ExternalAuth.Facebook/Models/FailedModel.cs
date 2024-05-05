using PowerStore.Core.Models;

namespace PowerStore.Plugin.ExternalAuth.Facebook.Models
{
    public class FailedModel : BaseModel
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
