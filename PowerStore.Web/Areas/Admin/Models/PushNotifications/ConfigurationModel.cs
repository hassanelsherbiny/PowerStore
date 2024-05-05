using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.PushNotifications
{
    public class ConfigurationModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.PushNotifications.NotificationsEnabled")]
        public bool Enabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.PushNotifications.PrivateApiKey")]
        public string PrivateApiKey { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.PushNotifications.PushApiKey")]
        public string PushApiKey { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.PushNotifications.SenderId")]
        public string SenderId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.PushNotifications.AuthDomain")]
        public string AuthDomain { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.PushNotifications.DatabaseUrl")]
        public string DatabaseUrl { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.PushNotifications.ProjectId")]
        public string ProjectId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.PushNotifications.StorageBucket")]
        public string StorageBucket { get; set; }
        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.PushNotifications.AppId")]
        public string AppId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.PushNotifications.AllowGuestNotifications")]
        public bool AllowGuestNotifications { get; set; }
    }
}
