using OutdoorPlanner.Models;

namespace OutdoorPlanner.ViewModels
{
    public class CommentCreateBindingModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string? Author { get; set; }
        public string? Content { get; set; }
    }
}
