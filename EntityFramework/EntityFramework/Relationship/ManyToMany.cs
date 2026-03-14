using EntityFrameworkCore_DotNet.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_DotNet.Relationship
{
    internal class ManyToMany
    {

        public class AppDbContext : DbContext
        {
            public DbSet<Instructor> Instructors { get; set; }
            public DbSet<Section> Sections { get; set; }
            public DbSet<InstructorSection> InstructorSections { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<InstructorSection>()
                    .HasOne(isec => isec.Instructor)
                    .WithMany(i => i.InstructorSections)
                    .HasForeignKey(isec => isec.InstructorId);

                modelBuilder.Entity<InstructorSection>()
                    .HasOne(isec => isec.Section)
                    .WithMany(s => s.InstructorSections)
                    .HasForeignKey(isec => isec.SectionId);
            }

        }
    }
}
