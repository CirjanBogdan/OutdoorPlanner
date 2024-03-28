using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OutdoorPlanner.Models;
using OutdoorPlanner.Services.Contracts;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Controllers
{
    public class NewsFeedController : Controller
    {
        private readonly INewsFeedService _newsFeedService;
        private readonly IInvitationsService _invitationsService;
        private readonly IEventService _eventService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public NewsFeedController(INewsFeedService newsFeedService, IInvitationsService invitationsService, IEventService eventService,
             UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _newsFeedService = newsFeedService;
            _invitationsService = invitationsService;
            _eventService = eventService;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> ShowEventPosts(int eventId)
        {
            var eventPosts = await _newsFeedService.GetEventPosts(eventId);
            return View(eventPosts);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CreatePost(int eventId)
        {
            var user = await _userManager.GetUserAsync(User);
            var userIsInvited = await _invitationsService.CheckIfInvitationExist(eventId, user.Email);

            if (!userIsInvited)
            {
                TempData["ErrorMessage"] = "You do not have access to create posts because you are not invited";
                return RedirectToAction("ShowEventPosts", new { eventId });
            }
            var @event = await _eventService.GetEventById(eventId);
            var postModel = new PostCreateBindingModel()
            {
                EventId = eventId,
                UserId = user.Id,
                EventViewModel = _mapper.Map<EventViewModel>(@event),
            };
            postModel.Author = user.Email;

            return View(postModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(PostCreateBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Title and content are mandatory.";
                return RedirectToAction("CreatePost", new { model.EventId });
            }
            bool postWasCreated = await _newsFeedService.CreateNewPost(model);

            if (!postWasCreated)
                TempData["ErrorMessage"] = "Error in creating the post. Please try again.";
            else
                TempData["SuccessMessage"] = "The post was successfully created";

            return RedirectToAction("ShowEventPosts", new { model.EventId });
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> EditPost(int postId)
        {
            var user = await _userManager.GetUserAsync(User);
            var post = await _newsFeedService.GetPostById(postId);
            if (post.Author == user.Email)
            {
                var postModel = _mapper.Map<PostEditBindingModel>(post);
                return View(postModel);
            } 
            else
                TempData["ErrorMessage"] = "Only the author can edit the post.";

            return RedirectToAction("ShowEventPosts", new { post.EventId});
        }

        [HttpPost]
        public async Task<IActionResult> EditPost(PostEditBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Title and content are mandatory.";
                return RedirectToAction("EditPost", new { model.EventId });
            }
            bool postWasEdited = await _newsFeedService.EditPost(model);

            if (!postWasEdited)
                TempData["ErrorMessage"] = "Error in editing the post. Please try again.";
            else
                TempData["SuccessMessage"] = "The post was successfully edited";

            return RedirectToAction("ShowEventPosts", new { model.EventId });
        }

        [HttpGet]
        public async Task<IActionResult> DeletePost(int postId)
        {
            var user = await _userManager.GetUserAsync(User);
            var post = await _newsFeedService.GetPostById(postId);
            if (post.Author != user.Email)
            {
                TempData["ErrorMessage"] = "Only the author can delete the post.";
                return RedirectToAction("ShowEventPosts", new { post.EventId });
            }
            var model = _mapper.Map<PostViewModel>(post);

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _newsFeedService.GetPostById(id);
            bool postWasDeleted = await _newsFeedService.DeletePost(id);

            if (!postWasDeleted)
                TempData["ErrorMessage"] = "Error in deleting the post. Please try again.";
            else
                TempData["SuccessMessage"] = "The post was successfully deleted";

            return RedirectToAction("ShowEventPosts", new { post.EventId });
        }
    }
}
