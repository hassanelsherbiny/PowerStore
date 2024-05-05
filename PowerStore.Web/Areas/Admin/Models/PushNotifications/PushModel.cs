using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.PushNotifications
{
    public partial class PushModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.PushNotifications.Fields.PushTitle")]
        public string Title { get; set; }

        [PowerStoreResourceDisplayName("Admin.PushNotifications.Fields.PushMessageText")]
        public string MessageText { get; set; }

        [UIHint("Picture")]
        [PowerStoreResourceDisplayName("Admin.PushNotifications.Fields.Picture")]
        public string PictureId { get; set; }

        [PowerStoreResourceDisplayName("Admin.PushNotifications.Fields.ClickUrl")]
        public string ClickUrl { get; set; }
    }
}
