using PowerStore.Core.Mapper;
using PowerStore.Domain.Courses;
using PowerStore.Web.Areas.Admin.Models.Courses;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class CourseMappingExtensions
    {
        public static CourseModel ToModel(this Course entity)
        {
            return entity.MapTo<Course, CourseModel>();
        }

        public static Course ToEntity(this CourseModel model)
        {
            return model.MapTo<CourseModel, Course>();
        }

        public static Course ToEntity(this CourseModel model, Course destination)
        {
            return model.MapTo(destination);
        }
    }
}