using PowerStore.Core.Mapper;
using PowerStore.Domain.Courses;
using PowerStore.Web.Areas.Admin.Models.Courses;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class CourseLessonMappingExtensions
    {
        public static CourseLessonModel ToModel(this CourseLesson entity)
        {
            return entity.MapTo<CourseLesson, CourseLessonModel>();
        }

        public static CourseLesson ToEntity(this CourseLessonModel model)
        {
            return model.MapTo<CourseLessonModel, CourseLesson>();
        }

        public static CourseLesson ToEntity(this CourseLessonModel model, CourseLesson destination)
        {
            return model.MapTo(destination);
        }
    }
}