using System.ComponentModel.DataAnnotations;

namespace CodeFirstDb.Dtos.StudentsDto
{
    public class StudentCreateDto
    {
        [MinLength(5)]
        public string StudentName { get; set; }
        [EmailAddress]
        public string StudentEmail { get; set; }
        public int ClassId { get; set; }
    }
}
