using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OutdoorPlanner.Data;
using OutdoorPlanner.Models;
using OutdoorPlanner.Services.Contracts;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Controllers
{
    public class InvitationsController : Controller
    {
        private readonly IInvitationsService _invitationsService;
        private readonly IUserService _userService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public InvitationsController(IInvitationsService invitationsService, UserManager<ApplicationUser> userManager,
            ApplicationDbContext context, IMapper mapper, IUserService userService)
        {
            _invitationsService = invitationsService;
            _userService = userService;
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }

        // Show the event invitations using a list of InvitationListViewModel
        // Show event details using EventViewModel
        public async Task<IActionResult> ShowEventInvitations(int eventId)
        {
            var result = await _invitationsService.GetInvitationsByEventId(eventId);
            return View(result);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> CreateInvitation(int eventId)
        {
            var creatorUserId = await _userService.GetUserIdByEventId(eventId);
            var currentUser = await _userManager.GetUserAsync(User);

            if (creatorUserId == currentUser.Id)
            {
                var model = new CreateInvitationBindingModel
                {
                    EventId = eventId
                };
                return View(model);
            }
            TempData["ErrorMessage"] = "Invitations can only be created by the event creator.";

            return RedirectToAction("ShowEventInvitations", new { eventId });
        }

        [HttpPost]
        public async Task<IActionResult> CreateInvitation(CreateInvitationBindingModel model)
        {
            bool invitationExist = await _invitationsService.CheckIfInvitationExist(model.EventId, model.UserEmail);
            if (invitationExist)
            {
                TempData["ErrorMessage"] = "User is already invited.";
                return RedirectToAction("ShowEventInvitations", new { eventId = model.EventId });
            }

            bool invitationCreated = await _invitationsService.CreateInvitationInDb(model);

            if (!invitationCreated)
                TempData["ErrorMessage"] = "The invited user is not valid or does not exist.";
            else
                TempData["SuccessMessage"] = "The invitation was successfuly sent.";

            return RedirectToAction("ShowEventInvitations", new { eventId = model.EventId });
        }

    }
}
