using PowerStore.Domain.Courses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Services.Courses
{
    public interface ICourseLevelService
    {
        Task<CourseLevel> GetById(string id);
        Task<IList<CourseLevel>> GetAll();
        Task<CourseLevel> Update(CourseLevel courseLevel);
        Task<CourseLevel> Insert(CourseLevel courseLevel);
        Task Delete(CourseLevel courseLevel);
    }
}
