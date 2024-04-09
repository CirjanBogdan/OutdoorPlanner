using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OutdoorPlanner.Models;
using OutdoorPlanner.Services.Contracts;

namespace OutdoorPlanner.Controllers
{
    public class LikeController : Controller
    {
        private readonly ILikeService _likeService;
        private readonly ICommentsService _commentsService;
        private readonly INewsFeedService _newsFeedService;
        private readonly IInvitationsService _invitationsService;
        private readonly IEventService _eventService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public LikeController(ILikeService likeService, INewsFeedService newsFeedService, ICommentsService commentsService, IInvitationsService invitationsService, IEventService eventService,
             UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _likeService = likeService;
            _commentsService = commentsService;
            _newsFeedService = newsFeedService;
            _invitationsService = invitationsService;
            _eventService = eventService;
            _userManager = userManager;
            _mapper = mapper;
        }

        [Authorize]
        public async Task<IActionResult> AddLikeToComment(int commentId)
        {
            var user = await _userManager.GetUserAsync(User);
            var comment = await _commentsService.GetCommentById(commentId);
            var userHasLikedComment = await _likeService.UserHasLikedComment(user.Id, commentId);

            if (!userHasLikedComment)
                await _likeService.AddLikeToComment(commentId, user.Id);
            else
                await _likeService.RemoveLikeFromComment(commentId, user.Id);

            return RedirectToAction("ShowPostComments", "Comments", new { comment.PostId });
        }
    }
}
