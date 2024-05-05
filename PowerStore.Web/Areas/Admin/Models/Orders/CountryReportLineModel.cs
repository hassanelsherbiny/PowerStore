using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class CountryReportLineModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Reports.Country.Fields.CountryName")]
        public string CountryName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Country.Fields.TotalOrders")]
        public int TotalOrders { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Country.Fields.SumOrders")]
        public string SumOrders { get; set; }
    }
}