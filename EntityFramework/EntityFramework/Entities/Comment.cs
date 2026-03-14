namespace EntityFrameworkCore_DotNet.Entities
{
    public class Comment
    {
        public int Id { get; set; }           // Primary key
        public string Text { get; set; }

        // Foreign key
        public int UserId { get; set; }

        // Navigation property: كل تعليق ينتمي لمستخدم واحد
        public User User { get; set; }

    }
}
