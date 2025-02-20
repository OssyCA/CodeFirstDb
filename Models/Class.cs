using System.ComponentModel.DataAnnotations; //data annotations create constraints for the model

namespace CodeFirstDb.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; } // Primary key property
        public string Name { get; set; } // Name property
        public virtual List<Student> Students { get; set; } // Navigation property
        public virtual List<ClassCourse> ClassCourses { get; set; } // Navigation property

    }
}
