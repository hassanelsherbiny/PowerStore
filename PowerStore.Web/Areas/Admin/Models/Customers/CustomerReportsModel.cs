using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class CustomerReportsModel : BaseModel
    {
        public BestCustomersReportModel BestCustomersByOrderTotal { get; set; }
        public BestCustomersReportModel BestCustomersByNumberOfOrders { get; set; }
    }
}