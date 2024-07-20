using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContosoUniversity.Models
{
    public class StudentViewModel
    {
        public List<Student>? Students { get; set; }
        public List<Enrollment>? Enrollments { get; set; }
        public List<Course>? Courses { get; set; }
    }
}
