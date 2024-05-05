using PowerStore.Domain.Courses;
using PowerStore.Domain.Customers;
using MediatR;

namespace PowerStore.Web.Features.Models.Courses
{
    public class GetCheckOrder : IRequest<bool>
    {
        public Customer Customer { get; set; }
        public Course Course { get; set; }
    }
}
