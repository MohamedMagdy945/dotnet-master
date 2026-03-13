using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_DotNet.Mapping
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");  // ربط الكلاس بالجدول
                entity.HasKey(e => e.Id);     // Primary Key
                entity.Property(e => e.Name)
                      .HasMaxLength(100)
                      .IsRequired();
            });


            // Mapping view
            modelBuilder.Entity<ActiveEmployee>(entity =>
            {
                entity.HasNoKey();            // مهم للـ View
                entity.ToView("ActiveEmployees");
            });
        }

    }
    public class App
    {
        public static void Run()
        {

            //var context = new AppDbContext(options);

            using (var context = new AppDbContext())
            {
                // Mapping function

                var employees = context.Set<Employee>()
                    .FromSqlRaw("SELECT * FROM GetEmployeesByDept({0})", 10)
                    .ToList();
            }

        }
    }
}
