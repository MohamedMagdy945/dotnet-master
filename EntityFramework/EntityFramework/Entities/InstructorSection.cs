namespace EntityFrameworkCore_DotNet.Entities
{
    public class InstructorSection
    {
        public int Id { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public int SectionId { get; set; }
        public Section Section { get; set; }

        public DateTime AssignedDate { get; set; }
    }
}
