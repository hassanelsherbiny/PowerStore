using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class OrderIncompleteReportLineModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Reports.Incomplete.Item")]
        public string Item { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Incomplete.Total")]
        public string Total { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Incomplete.Count")]
        public int Count { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Incomplete.View")]
        public string ViewLink { get; set; }
    }
}
