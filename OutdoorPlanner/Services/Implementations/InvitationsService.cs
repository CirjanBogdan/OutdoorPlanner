using OutdoorPlanner.Data;
using OutdoorPlanner.Models;
using OutdoorPlanner.Services.Contracts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Services.Implementations
{
    public class InvitationsService : IInvitationsService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IEventService _eventService;
        private readonly UserManager<ApplicationUser> _userManager;

        public InvitationsService(ApplicationDbContext context, IMapper mapper, IEventService eventService, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _eventService = eventService;
            _userManager = userManager;
        }



        public async Task<InvitationsEventViewModel> GetInvitationsByEventId(int eventId)
        {
            var @event = await _eventService.GetEventById(eventId);
            var invitations = await _context.Invitations.Where(e => e.EventId == eventId).ToListAsync();
            var result = new InvitationsEventViewModel
            {
                EventViewModel = _mapper.Map<EventViewModel>(@event),
                InvitationListViewModel = _mapper.Map<List<InvitationViewModel>>(invitations)
            };
            return result;

        }

        public async Task<bool> CreateInvitationInDb(CreateInvitationBindingModel model)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == model.UserEmail);
                if (user != null)
                {
                    var invitation = _mapper.Map<Invitation>(model);
                    await _context.Invitations.AddAsync(invitation);
                    await _context.SaveChangesAsync();
                    var userInvitation = new UserInvitation
                    {
                        Invitation = invitation,
                        InvitationId = invitation.Id,
                        UserId = user.Id,
                    };
                    await _context.UserInvitations.AddAsync(userInvitation);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            } catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> CheckIfInvitationExist(int eventId, string email)
        {
            bool checkInvitation = await _context.Invitations.AnyAsync(e => e.EventId == eventId && e.UserEmail == email);
            return checkInvitation;
        }
    }
}

