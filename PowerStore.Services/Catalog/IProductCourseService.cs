using PowerStore.Domain.Catalog;
using PowerStore.Domain.Courses;
using System.Threading.Tasks;

namespace PowerStore.Services.Catalog
{
    public interface IProductCourseService
    {
        Task<Product> GetProductByCourseId(string courseId);
        Task<Course> GetCourseByProductId(string productId);
        Task UpdateCourseOnProduct(string productId, string courseId);
    }
}
