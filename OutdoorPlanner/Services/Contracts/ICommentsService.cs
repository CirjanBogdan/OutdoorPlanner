using OutdoorPlanner.Models;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Services.Contracts
{
    public interface ICommentsService
    {
        public Task<CommentsAndPostViewModel> GetPostComments(int postId);
        public Task<bool> CreateComment(CommentCreateBindingModel model, string userId);

        public Task<bool> EditComment(CommentCreateBindingModel model);

        public Task<Comment> GetCommentById(int id);

        public Task<bool> DeleteCommentById(int id);
    }
}
