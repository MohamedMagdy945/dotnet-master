namespace EntityFrameworkCore_DotNet.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property: كل User له Profile واحد

        public UserProfile Profile { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}
