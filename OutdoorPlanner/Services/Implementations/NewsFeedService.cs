using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OutdoorPlanner.Data;
using OutdoorPlanner.Models;
using OutdoorPlanner.Services.Contracts;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Services.Implementations
{
    public class NewsFeedService : INewsFeedService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public NewsFeedService(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IMapper mapper)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }

        public async Task<Post> GetPostById(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            return post;
        }

        public async Task<PostsEventViewModel> GetEventPosts(int eventId)
        {
            var @event = await _context.Events.FindAsync(eventId);
            var postList = await _context.Posts.Where(e => e.EventId == eventId).OrderByDescending(post => post.CreatedAt).ToListAsync();

            var postsEventViewModel = new PostsEventViewModel
            {
                EventViewModel = _mapper.Map<EventViewModel>(@event),
                PostsList = _mapper.Map<IEnumerable<PostViewModel>>(postList)
            };
            return postsEventViewModel;
        }

        public async Task<bool> CreateNewPost(PostCreateBindingModel model)
        {
            try
            {
                if (model.Content is not null)
                {
                    var user = await _context.Users.FindAsync(model.UserId);
                    var @event = await _context.Events.Where(e => e.Id == model.EventId).FirstOrDefaultAsync();
                    var post = _mapper.Map<Post>(model);
                    await _context.Posts.AddAsync(post);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            } catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> EditPost(PostEditBindingModel model)
        {
            try
            {
                var post = await _context.Posts.FindAsync(model.Id);
                post = _mapper.Map<Post>(model);
                _context.Posts.Update(post);
                await _context.SaveChangesAsync();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeletePost(int id)
        {
            try
            {
                var post = await _context.Posts.FindAsync(id);
                _context.Posts.Remove(post);
                await _context.SaveChangesAsync();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
