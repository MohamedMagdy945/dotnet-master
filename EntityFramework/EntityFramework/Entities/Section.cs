namespace EntityFrameworkCore_DotNet.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<InstructorSection> InstructorSections { get; set; } = new List<InstructorSection>();
    }
}
