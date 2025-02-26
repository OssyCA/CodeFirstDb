using CodeFirstDb.Data;
using CodeFirstDb.Dtos.StudentsDto;
using CodeFirstDb.Endpoints.StudentEndpointsFolder;
using CodeFirstDb.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            
            
            
            
            builder.Services.AddDbContext<SchoolDbContext>(option => // dependency injection, meaning that the SchoolDbContext will be injected into the lambda expression
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"));

            });
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            // dependency injection, meaning that the WebApplication will be injected into the RegisterEndpoints method
            // RegisterEndpoints is a method that registers the endpoints
            StudentEndpoints.RegisterEndpoints(app);




            app.Run();
        }
    }
}
