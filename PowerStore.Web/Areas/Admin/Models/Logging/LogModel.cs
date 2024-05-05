using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;

namespace PowerStore.Web.Areas.Admin.Models.Logging
{
    public partial class LogModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.System.Log.Fields.LogLevel")]
        public string LogLevel { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Log.Fields.ShortMessage")]
        
        public string ShortMessage { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Log.Fields.FullMessage")]
        
        public string FullMessage { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Log.Fields.IPAddress")]
        
        public string IpAddress { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Log.Fields.Customer")]
        public string CustomerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.System.Log.Fields.Customer")]
        public string CustomerEmail { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Log.Fields.PageURL")]
        
        public string PageUrl { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Log.Fields.ReferrerURL")]
        
        public string ReferrerUrl { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Log.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
    }
}