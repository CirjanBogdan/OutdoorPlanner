using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutdoorPlanner.Data;
using OutdoorPlanner.Models;
using OutdoorPlanner.Services.Contracts;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Services.Implementations
{
    public class CommentsService : ICommentsService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CommentsService(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IMapper mapper)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }

        public async Task<CommentsAndPostViewModel> GetPostComments(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);
            var commentsList = await _context.Comments.Where(p => p.PostId == postId).ToListAsync();
            var commentsAndPost = new CommentsAndPostViewModel
            {
                CommentsListViewModel = _mapper.Map<List<CommentViewModel>>(commentsList),
                PostViewModel = _mapper.Map<PostViewModel>(post),
            };
            return commentsAndPost;
        }

        public async Task<bool> CreateComment(CommentCreateBindingModel model, string userId)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                var post = await _context.Posts.FindAsync(model.PostId);
                var comment = _mapper.Map<Comment>(model);

                comment.UserId = user.Id;
                comment.PostId = post.Id;

                post.CommentsNumber++;

                _context.Posts.Update(post);
                await _context.Comments.AddAsync(comment);
                await _context.SaveChangesAsync();
                return true;
            } 
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> EditComment(CommentCreateBindingModel model)
        {
            try
            {
                var comment = await _context.Comments.FindAsync(model.Id);
                comment = _mapper.Map<Comment>(model);
                _context.Comments.Update(comment);
                await _context.SaveChangesAsync();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public async Task<Comment> GetCommentById(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            return comment;
        }

        public async Task<bool> DeleteCommentById(int commentId)
        {
            try
            {
                var comment = await _context.Comments.FindAsync(commentId);
                var post = await _context.Posts.FindAsync(comment.PostId);
                post.CommentsNumber--;
                _context.Posts.Update(post);
                _context.Comments.Remove(comment);
                await _context.SaveChangesAsync();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
