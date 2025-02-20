using Microsoft.EntityFrameworkCore;
using CodeFirstDb.Models;

namespace CodeFirstDb.Data
{
    public class SchoolDbContext: DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> dbContextOptions) : base(dbContextOptions)
        {


            // This is the connection string to the database
            //Data Source=OSSMAN\MSSQLSERVER01;Database=SchoolDbCodeFirst;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;
        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ClassCourse> ClassCourses { get; set; }
    }
}
