namespace OutdoorPlanner.Models
{
    public class Like
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public int CommentId { get; set; }
        public Comment? Comment { get; set; }
    }
}
