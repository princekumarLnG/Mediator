using Mediator.Models;
using Microsoft.EntityFrameworkCore;

namespace Mediator.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee {Id=1, Name = "Prince", Email = "prince@gmail.com", Phone = "1234567890", Gender = Gender.Male },
                new Employee {Id=2, Name = "test1", Email = "test1@gmail.com", Phone = "1234567890", Gender = Gender.Female },
                new Employee {Id=3, Name = "test2", Email = "test2@gmail.com", Phone = "1234567890", Gender = Gender.Others }

            // Add more departments here as needed
            );
        }

    }
}
