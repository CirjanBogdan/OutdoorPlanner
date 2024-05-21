namespace OutdoorPlanner.Services.Contracts
{
    public interface ILikeService
    {
        public Task<bool> AddLikeToComment(int id, string userId);
        public Task<bool> RemoveLikeFromComment(int id, string userId);
        public Task<bool> UserHasLikedComment(string userId, int commentId);

        public Task<bool> AddLikeToPost(int id, string userId);
        public Task<bool> RemoveLikeFromPost(int id, string userId);
        public Task<bool> UserHasLikedPost(string userId, int postId);
    }
}
