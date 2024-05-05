using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Customer;
using MediatR;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetCourses : IRequest<CoursesModel>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}
