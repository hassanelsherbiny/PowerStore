using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class CustomerTagModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Customers.CustomerTags.Fields.Name")]

        public string Name { get; set; }
    }
}