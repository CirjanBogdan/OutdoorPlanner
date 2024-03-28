using OutdoorPlanner.Models;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Services.Contracts
{
    public interface INewsFeedService
    {
        public Task<Post> GetPostById(int id);
        public Task<PostsEventViewModel> GetEventPosts(int id);
        public Task<bool> CreateNewPost(PostCreateBindingModel model);
        public Task<bool> EditPost(PostEditBindingModel model);
        public Task<bool> DeletePost(int id);
        
    }
}
