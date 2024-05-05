using PowerStore.Domain.Courses;
using PowerStore.Domain.Customers;
using MediatR;

namespace PowerStore.Web.Commands.Models.Courses
{
    public class CourseLessonApprovedCommand : IRequest<bool>
    {
        public Course Course { get; set; }
        public CourseLesson Lesson { get; set; }
        public Customer Customer { get; set; }
    }
}
