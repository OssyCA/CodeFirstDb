using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDb.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [StringLength(35, MinimumLength = 5)]
        public string Name{ get; set; }
        [StringLength(100)]
        public string Email { get; set; } // Email property

        [ForeignKey("Class")] // Foreign key attribute
        public int? ClassId_FK { get; set; } // Foreign key property
        public virtual Class Class { get; set; } // Navigation property
    }
}
