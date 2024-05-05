using PowerStore.Core.ModelBinding;
using PowerStore.Framework.Mvc.Models;
using System.Collections.Generic;

namespace PowerStore.Framework.Mapping
{
    public interface IAclMappingModel
    {
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.SubjectToAcl")]
        bool SubjectToAcl { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.AclCustomerRoles")]
        List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        string[] SelectedCustomerRoleIds { get; set; }
    }
}
