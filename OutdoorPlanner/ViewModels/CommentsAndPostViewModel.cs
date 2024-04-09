namespace OutdoorPlanner.ViewModels
{
    public class CommentsAndPostViewModel
    {
        public int Id { get; set; }
        public PostViewModel? PostViewModel { get; set; }
        public List<CommentViewModel>? CommentsListViewModel { get; set; }
    }
}
