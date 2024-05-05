using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class NeverSoldReportModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Reports.NeverSold.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.NeverSold.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }
    }
}