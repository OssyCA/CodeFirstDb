using System.ComponentModel.DataAnnotations;

namespace CodeFirstDb.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public virtual List<ClassCourse> ClassCourses { get; set; }

    }
}
