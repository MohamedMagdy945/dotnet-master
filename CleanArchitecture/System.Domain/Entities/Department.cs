using System.ComponentModel.DataAnnotations;

namespace MySystem.Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Student> Students { get; private set; } = new List<Student>();

    }
}
