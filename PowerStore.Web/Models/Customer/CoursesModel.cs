using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Customer
{
    public class CoursesModel : BaseModel
    {
        public CoursesModel()
        {
            CourseList = new List<Course>();
        }

        public List<Course> CourseList { get; set; }
        public string CustomerId { get; set; }

        public class Course : BaseEntityModel
        {
            public string Name { get; set; }
            public string SeName { get; set; }
            public string ShortDescription { get; set; }
            public string Level { get; set; }
            public bool Approved { get; set; }
        }
    }

   
}
