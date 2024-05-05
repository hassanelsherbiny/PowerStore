using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Courses
{
    public partial class CourseLevelModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Courses.Level.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Level.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

    }
}
