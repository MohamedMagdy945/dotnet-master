using EntityFrameworkCore_DotNet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore_DotNet.EntityConfiguration.ConfigurationClasses_EntityTypeConfiguration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(e => e.Salary)
                   .HasColumnType("decimal(10,2)");
        }
        public class AppDbContext : DbContext
        {
            public DbSet<Employee> Employees { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

                new EmployeeConfiguration().Configure(modelBuilder.Entity<Employee>());

            }
        }
    }
}
