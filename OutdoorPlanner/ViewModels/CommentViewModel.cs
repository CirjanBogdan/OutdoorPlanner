using OutdoorPlanner.Models;

namespace OutdoorPlanner.ViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string? Author { get; set; } 
        public string? Content { get; set; }
        public int LikesNumber { get; set; }

        public string? UserId { get; set; }
        public int PostId { get; set; }
    }
}
