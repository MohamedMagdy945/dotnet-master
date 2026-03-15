
namespace EntityFrameworkCore_DotNet.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }
        public List<Comment> Comments { get; set; }
        public Section Section { get; set; }
    }
}
