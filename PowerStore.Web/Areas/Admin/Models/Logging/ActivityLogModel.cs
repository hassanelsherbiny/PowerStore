using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;

namespace PowerStore.Web.Areas.Admin.Models.Logging
{
    public partial class ActivityLogModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.ActivityLog.ActivityLog.Fields.ActivityLogType")]
        public string ActivityLogTypeName { get; set; }
        public string ActivityLogTypeId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.ActivityLog.ActivityLog.Fields.Customer")]
        public string CustomerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Configuration.ActivityLog.ActivityLog.Fields.Customer")]
        public string CustomerEmail { get; set; }
        [PowerStoreResourceDisplayName("Admin.Configuration.ActivityLog.ActivityLog.Fields.Comment")]
        public string Comment { get; set; }
        [PowerStoreResourceDisplayName("Admin.Configuration.ActivityLog.ActivityLog.Fields.IpAddress")]
        public string IpAddress { get; set; }
        [PowerStoreResourceDisplayName("Admin.Configuration.ActivityLog.ActivityLog.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
    }

    public partial class ActivityStatsModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.ActivityLog.ActivityStats.Fields.ActivityLogType")]
        public string ActivityLogTypeName { get; set; }
        public string ActivityLogTypeId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.ActivityLog.ActivityStats.Fields.EntityKeyId")]
        public string EntityKeyId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.ActivityLog.ActivityStats.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.ActivityLog.ActivityStats.Fields.Count")]
        public int Count { get; set; }

    }
}
