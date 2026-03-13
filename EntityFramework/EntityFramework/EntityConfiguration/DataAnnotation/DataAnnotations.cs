using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCore_DotNet.EntityConfiguration.DataAnnotation
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }
    }
}
