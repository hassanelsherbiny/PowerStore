using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class NeverSoldReportLineModel : BaseModel
    {
        public string ProductId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Reports.NeverSold.Fields.Name")]
        public string ProductName { get; set; }
    }
}