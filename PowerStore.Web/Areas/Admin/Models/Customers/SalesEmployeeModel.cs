using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class SalesEmployeeModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Customers.SalesEmployee.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.SalesEmployee.Fields.Email")]
        public string Email { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.SalesEmployee.Fields.Phone")]
        public string Phone { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.SalesEmployee.Fields.Active")]
        public bool Active { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.SalesEmployee.Fields.Commission")]
        public decimal? Commission { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.SalesEmployee.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

    }
}