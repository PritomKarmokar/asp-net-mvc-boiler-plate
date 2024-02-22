using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Rahim", Email = "rahim@abc.com"},
                new Employee { Id = 2, Name = "Karim", Email = "karim@gmail.com" },
                new Employee { Id = 3, Name = "Shakib", Email = "shakib@gmail.com" }
                );
        }
    }
}
