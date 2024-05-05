using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Courses
{
    public partial class CourseSubjectModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Courses.Course.Subject.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Subject.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public string CourseId { get; set; }

    }
}
