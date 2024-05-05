using PowerStore.Domain;
using PowerStore.Domain.Courses;
using PowerStore.Domain.Customers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Services.Courses
{
    public interface ICourseService
    {
        Task<Course> GetById(string id);
        Task<IPagedList<Course>> GetAll(int pageIndex = 0, int pageSize = int.MaxValue);
        Task<IList<Course>> GetByCustomer(Customer customer, string storeId);
        Task<Course> Update(Course course);
        Task<Course> Insert(Course course);
        Task Delete(Course course);
    }
}
