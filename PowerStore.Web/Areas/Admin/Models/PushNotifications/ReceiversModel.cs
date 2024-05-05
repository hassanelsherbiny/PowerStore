using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.PushNotifications
{
    public class ReceiversModel : BaseModel
    {
        public int Allowed { get; set; }

        public int Denied { get; set; }
    }
}
