using OutdoorPlanner.Models;

namespace OutdoorPlanner.ViewModels
{
    public class PostsEventViewModel
    {
        public int Id { get; set; }
        public EventViewModel? EventViewModel { get; set; }
        public IEnumerable<PostViewModel>? PostsList { get; set; }
    }
}
