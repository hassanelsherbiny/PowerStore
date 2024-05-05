using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Templates
{
    public partial class TopicTemplateModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.System.Templates.Topic.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Templates.Topic.ViewPath")]

        public string ViewPath { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Templates.Topic.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}