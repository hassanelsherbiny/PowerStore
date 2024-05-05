using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;


namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class OrderPeriodReportLineModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Reports.Period.Name")]
        public string Period { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Period.Count")]
        public int Count { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Period.Amount")]
        public decimal Amount { get; set; }

    }
}