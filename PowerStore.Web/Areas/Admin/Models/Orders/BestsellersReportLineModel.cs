using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class BestsellersReportLineModel : BaseModel
    {
        public string ProductId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Reports.Bestsellers.Fields.Name")]
        public string ProductName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Bestsellers.Fields.TotalAmount")]
        public string TotalAmount { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Bestsellers.Fields.TotalQuantity")]
        public decimal TotalQuantity { get; set; }
    }
}