using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OutdoorPlanner.Models;
using OutdoorPlanner.Services.Contracts;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentsService _commentsService;
        private readonly INewsFeedService _newsFeedService;
        private readonly IInvitationsService _invitationsService;
        private readonly IEventService _eventService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public CommentsController(INewsFeedService newsFeedService, ICommentsService commentsService, IInvitationsService invitationsService, IEventService eventService,
             UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _commentsService = commentsService;
            _newsFeedService = newsFeedService;
            _invitationsService = invitationsService;
            _eventService = eventService;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> ShowPostComments(int postId)
        {
            var eventPosts = await _commentsService.GetPostComments(postId);
            return View(eventPosts);
        }

        [HttpGet]
        public async Task<IActionResult> CreateComment(int postId)
        {
            var user = await _userManager.GetUserAsync(User);
            var post = await _newsFeedService.GetPostById(postId);
            var userIsInvited = await _invitationsService.CheckIfInvitationExist(post.EventId, user.Email);

            if (!userIsInvited)
            {
                TempData["ErrorMessage"] = "You do not have access to comment because you are not invited to the event";
                return RedirectToAction("ShowPostComments", new { postId });
            }

            var model = new CommentCreateBindingModel
            {
                Author = user.Email,
                PostId = postId,
            };
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateComment(CommentCreateBindingModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            var commentCreated = await _commentsService.CreateComment(model, user.Id);

            if (!commentCreated)
                TempData["ErrorMessage"] = "Error in creating the comment. Please try again.";
            else
                TempData["SuccessMessage"] = "The comment was successfully posted";

            return RedirectToAction("ShowPostComments", new { model.PostId });
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> EditComment(int commentId)
        {
            var commentBindModel = _mapper.Map<CommentCreateBindingModel>(await _commentsService.GetCommentById(commentId));
            var user = await _userManager.GetUserAsync(User);

            if (commentBindModel.Author != user.Email)
            {
                TempData["ErrorMessage"] = "Only the author can edit the comment.";
                return RedirectToAction("ShowPostComments", new { commentBindModel.PostId });
            }
                
            return View(commentBindModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditComment(CommentCreateBindingModel model)
        {
            var commentEdited = await _commentsService.EditComment(model);
            if (!commentEdited)
                TempData["ErrorMessage"] = "Error in editing the comment. Please try again.";
            else
                TempData["SuccessMessage"] = "The comment was successfully updated";

            return RedirectToAction("ShowPostComments", new { model.PostId });
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> DeleteComment(int commentId)
        {
            var comment = await _commentsService.GetCommentById(commentId);
            var user = await _userManager.GetUserAsync(User);

            if (comment.Author != user.Email)
            {
                TempData["ErrorMessage"] = "Only the author can delete the comment.";
                return RedirectToAction("ShowPostComments", new { comment.PostId });
            }

            return View(comment);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCommentById(int commentId)
        {
            var comment = await _commentsService.GetCommentById(commentId);
            var commentDeleted = await _commentsService.DeleteCommentById(commentId);
            if (!commentDeleted)
                TempData["ErrorMessage"] = "Error in deleting the comment. Please try again.";
            else
                TempData["SuccessMessage"] = "The comment was successfully deleted";

            return RedirectToAction("ShowPostComments", new { comment.PostId });
        }
    }
}
