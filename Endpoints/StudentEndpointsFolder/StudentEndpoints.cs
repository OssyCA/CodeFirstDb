using CodeFirstDb.Data;
using CodeFirstDb.Dtos.StudentsDto;
using CodeFirstDb.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDb.Endpoints.StudentEndpointsFolder
{
    public class StudentEndpoints
    {
        public static void  RegisterEndpoints(WebApplication app) // RegisterEndpoints is a method that registers the endpoints, dependency injection is used to inject the WebApplication into the method
        {
            // This is the endpoint that will return the data from the database REST API
            app.MapGet("/Students", async (SchoolDbContext context) => // MapGet is a method that maps a GET request to a specific path
            {
                var students = await context.Students.Select(s => new StudentDto
                {
                    StudentName = s.Name,
                    StudentEmail = s.Email
                }).ToListAsync();

                return Results.Ok(students);

            });
            app.MapPost("/Students", async (StudentCreateDto newStudent, SchoolDbContext context) => // MapPost is a method that maps a POST request to a specific path
            {
                var validContext =new ValidationContext (newStudent, null, null);
                var validResults = new List<ValidationResult>(); // List that will contain the results of the validation

                // newStudent is the object that will be validated, validContext is the context in which the validation will be done, validResults is the list that will contain the results of the validation
                bool isValid = Validator.TryValidateObject(newStudent, validContext, validResults, true);

                if (!isValid)
                {
                    return Results.BadRequest(validResults);
                }

                var student = new Student
                {
                    Name = newStudent.StudentName,
                    Email = newStudent.StudentEmail,
                    ClassId_FK = newStudent.ClassId
                };

                context.Students.Add(student);
                await context.SaveChangesAsync();

                return Results.Ok(student);
            });
            app.MapGet("/Students/{id}", async (SchoolDbContext context, int id) =>
            {
                var student = await context.Students.FirstOrDefaultAsync(s => s.StudentID == id);

                if (student == null)
                {
                    Console.WriteLine("Student not found");
                    return Results.NotFound();
                }
                Console.WriteLine("Student found");
                return Results.Ok(student); // Returnera IResult i båda fallen
            });
            app.MapDelete("/Students/{id}", async (SchoolDbContext context, int id) =>
            {
                var student = await context.Students.FirstOrDefaultAsync(s => s.StudentID == id);
                if (student == null)
                {
                    Console.WriteLine("Student not found");
                    return Results.NotFound();
                }
                context.Students.Remove(student);
                context.SaveChanges();
                return Results.Ok();
            });
            app.MapPut("/students/{id}", async (SchoolDbContext context, int id, Student student) =>
            {
                var existingStudent = await context.Students.FirstOrDefaultAsync(s => s.StudentID == id);

                if (existingStudent == null)
                {
                    Console.WriteLine("Student not found");
                    return Results.NotFound();
                }
                existingStudent.Name = student.Name;
                existingStudent.Email = student.Email;
                existingStudent.ClassId_FK = student.ClassId_FK;

                context.SaveChanges();
                return Results.Ok(existingStudent);

            });

        }
    }
}
