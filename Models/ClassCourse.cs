using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDb.Models
{
    public class ClassCourse
    {
        [Key]
        public int ClassCourseID { get; set; } // Primary key property
        [ForeignKey("Class")]
        public int ClassID_Fk { get; set; } // Foreign key property
        public virtual Class Class { get; set; } // Navigation property
        [ForeignKey("Course")]
        public int CourseID_Fk { get; set; } // Foreign key property
        public virtual Course Course { get; set; } // Navigation property
    }
}
