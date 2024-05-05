using PowerStore.Domain.Courses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Services.Courses
{
    public interface ICourseLessonService
    {
        Task<CourseLesson> GetById(string id);
        Task<IList<CourseLesson>> GetByCourseId(string courseId);
        Task<CourseLesson> Update(CourseLesson courseLesson);
        Task<CourseLesson> Insert(CourseLesson courseLesson);
        Task Delete(CourseLesson courseLesson);
    }
}
