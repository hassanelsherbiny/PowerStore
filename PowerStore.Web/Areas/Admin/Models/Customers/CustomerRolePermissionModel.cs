using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public class CustomerRolePermissionModel : BaseEntityModel
    {
        public CustomerRolePermissionModel()
        {
            Actions = new List<string>();
        }
        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Acl.Fields.Name")]
        public string Name { get; set; }

        public string SystemName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Acl.Fields.Access")]
        public bool Access { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerRoles.Acl.Fields.Actions")]
        public IList<string> Actions { get; set; }
    }
}
