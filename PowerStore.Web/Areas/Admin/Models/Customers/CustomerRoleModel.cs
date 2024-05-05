using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class CustomerRoleModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Fields.FreeShipping")]

        public bool FreeShipping { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Fields.TaxExempt")]
        public bool TaxExempt { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Fields.Active")]
        public bool Active { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Fields.IsSystemRole")]
        public bool IsSystemRole { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Fields.SystemName")]
        public string SystemName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Fields.EnablePasswordLifetime")]
        public bool EnablePasswordLifetime { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Fields.MinOrderAmount")]
        [UIHint("DecimalNullable")]
        public decimal? MinOrderAmount { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Fields.MaxOrderAmount")]
        [UIHint("DecimalNullable")]
        public decimal? MaxOrderAmount { get; set; }

    }
}