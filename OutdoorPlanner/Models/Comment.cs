namespace OutdoorPlanner.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Author { get; set; }
        public string? Content { get; set; }
        public int LikesNumber { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }
        public int PostId { get; set; }
        public Post? Post { get; set; }

        public ICollection<Like>? Likes { get; set; }
    }
}
