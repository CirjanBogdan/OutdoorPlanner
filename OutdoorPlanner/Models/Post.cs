namespace OutdoorPlanner.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string Content { get; set; } = null!;
        public int CommentsNumber { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool Edited { get; set; } = false;

        public int EventId { get; set; }
        public Event? Event { get; set; }
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
