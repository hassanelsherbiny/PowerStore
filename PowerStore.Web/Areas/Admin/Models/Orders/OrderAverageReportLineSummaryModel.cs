using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class OrderAverageReportLineSummaryModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Reports.Average.OrderStatus")]
        public string OrderStatus { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Average.SumTodayOrders")]
        public string SumTodayOrders { get; set; }
        
        [PowerStoreResourceDisplayName("Admin.Reports.Average.SumThisWeekOrders")]
        public string SumThisWeekOrders { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Average.SumThisMonthOrders")]
        public string SumThisMonthOrders { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Average.SumThisYearOrders")]
        public string SumThisYearOrders { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Average.SumAllTimeOrders")]
        public string SumAllTimeOrders { get; set; }
    }
}
