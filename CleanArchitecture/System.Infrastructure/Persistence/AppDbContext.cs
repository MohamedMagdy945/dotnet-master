using Microsoft.EntityFrameworkCore;
using MySystem.Domain.Entities;

namespace MySystem.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
