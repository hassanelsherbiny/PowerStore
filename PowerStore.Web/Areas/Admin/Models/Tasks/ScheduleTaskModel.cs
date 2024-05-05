using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Tasks
{
    public partial class ScheduleTaskModel : BaseEntityModel
    {
        public ScheduleTaskModel()
        {
            AvailableStores = new List<SelectListItem>();
        }
        [PowerStoreResourceDisplayName("Admin.System.ScheduleTasks.ScheduleTaskName")]
        public string ScheduleTaskName { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.ScheduleTasks.LeasedByMachineName")]
        public string LeasedByMachineName { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.ScheduleTasks.Type")]
        public string Type { get; set; }
        [PowerStoreResourceDisplayName("Admin.System.ScheduleTasks.Enabled")]
        public bool Enabled { get; set; }
        [PowerStoreResourceDisplayName("Admin.System.ScheduleTasks.StopOnError")]
        public bool StopOnError { get; set; }
        [PowerStoreResourceDisplayName("Admin.System.ScheduleTasks.LastStartUtc")]
        public DateTime? LastStartUtc { get; set; }
        [PowerStoreResourceDisplayName("Admin.System.ScheduleTasks.LastEndUtc")]
        public DateTime? LastEndUtc { get; set; }
        [PowerStoreResourceDisplayName("Admin.System.ScheduleTasks.LastSuccessUtc")]
        public DateTime? LastSuccessUtc { get; set; }
        [PowerStoreResourceDisplayName("Admin.System.ScheduleTasks.TimeInterval")]
        public int TimeInterval { get; set; }
        [PowerStoreResourceDisplayName("Admin.System.ScheduleTasks.StoreId")]
        public string StoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
    }
}