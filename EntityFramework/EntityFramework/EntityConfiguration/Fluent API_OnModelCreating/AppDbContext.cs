using EntityFrameworkCore_DotNet.Entities;
using Microsoft.EntityFrameworkCore;


namespace EntityFrameworkCore_DotNet.EntityConfiguration.Fluent_API_OnModelCreating
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Salary)
                      .HasColumnType("decimal(10,2)");
            });
        }
    }
}
