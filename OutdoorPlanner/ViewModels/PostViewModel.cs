using OutdoorPlanner.Models;

namespace OutdoorPlanner.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string Content { get; set; } = null!;
        public int CommentsNumber { get; set; }
        public int LikesNumber { get; set; }
        public bool Edited { get; set; }
        public DateTime CreatedAt { get; set; }
        public int EventId { get; set; }
        public string? UserId { get; set; }
    }
}
