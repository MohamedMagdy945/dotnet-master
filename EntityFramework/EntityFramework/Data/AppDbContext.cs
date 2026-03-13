

using EntityFrameworkCore_DotNet.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_DotNet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
