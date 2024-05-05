using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Documents
{
    public partial class DocumentTypeModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Documents.Type.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Type.Fields.Description")]

        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Type.Fields.DisplayOrder")]

        public int DisplayOrder { get; set; }
    }
}
