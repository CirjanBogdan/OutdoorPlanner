using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OutdoorPlanner.Data;
using OutdoorPlanner.Models;
using OutdoorPlanner.Services.Contracts;

namespace OutdoorPlanner.Services.Implementations
{
    public class LikeService : ILikeService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public LikeService(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IMapper mapper)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddLikeToComment(int commentId, string userId)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                var comment = await _context.Comments.FindAsync(commentId);
                
                var like = new Like
                {
                    Comment = comment,
                    CommentId = commentId,
                    UserId = user.Id,
                };
                comment.LikesNumber++;
                await _context.Likes.AddAsync(like);
                _context.Comments.Update(comment);
                await _context.SaveChangesAsync();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> RemoveLikeFromComment(int commentId, string userId)
        {
            try
            {
                var comment = await _context.Comments.FindAsync(commentId);
                var like = await _context.Likes.Where(c => c.CommentId == commentId && c.UserId == userId).FirstOrDefaultAsync();
                comment.LikesNumber--;
                _context.Likes.Remove(like);
                _context.Comments.Update(comment);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UserHasLikedComment(string userId, int commentId)
        {
            var commentIsLiked = await _context.Likes.Where(u => u.UserId == userId && u.CommentId == commentId).FirstOrDefaultAsync();

            if (commentIsLiked is not null)
                return true;
            else
                return false;
        }

        public async Task<bool> AddLikeToPost(int id, string userId)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                var post = await _context.Posts.FindAsync(id);

                var like = new Like
                {
                    PostId = id,
                    UserId = user.Id,
                };

                post.LikesNumber++;
                await _context.Likes.AddAsync(like);
                _context.Posts.Update(post);
                await _context.SaveChangesAsync();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UserHasLikedPost(string userId, int postId)
        {
            var postIsLiked = await _context.Likes.Where(p => p.PostId == postId && p.UserId == userId).FirstOrDefaultAsync();

            var likes = _context.Likes.Where(p => p.PostId == postId && p.UserId == userId).Count();

            if (postIsLiked is not null)
                return true;
            else
                return false;
        }

        public async Task<bool> RemoveLikeFromPost(int id, string userId)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                var post = await _context.Posts.FindAsync(id);
                var like = await _context.Likes.Where(u => u.UserId == userId && u.PostId == id).FirstOrDefaultAsync();
                post.LikesNumber--;
                _context.Likes.Remove(like);
                _context.Posts.Update(post);
                await _context.SaveChangesAsync();
                return true;
            } catch (Exception)
            {
                return false;
            }
             
        }
    }
}
