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
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IEventService _eventService;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(ApplicationDbContext context, IMapper mapper, IEventService eventService, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _eventService = eventService;
            _userManager = userManager;
        }

        public async Task<string> GetUserIdByEventId(int eventId)
        {
            var creatorUserId = await _context.Events.Where(e => e.Id == eventId).Select(e => e.UserId)
                                        .FirstOrDefaultAsync();
            return creatorUserId;
        }

        public async Task<List<InvitationViewModel>> GetUserInvitations(string userId)
        {
            var user = await _context.Users.FindAsync(userId);
            var invitations = await _context.Invitations.Where(u => u.UserEmail == user.Email).ToListAsync();
            var result = _mapper.Map<List<InvitationViewModel>>(invitations);
            foreach ( var invitation in result )
            {
                var @event = await _context.Events.FirstOrDefaultAsync(e => e.Id == invitation.EventId);
                invitation.EventName = @event.Name;
                invitation.InvitationId = invitation.Id;
            }
            return result;
        }

        public async Task<bool> UpdateUserInvitation(int invitationId, string status)
        {
            var invitation = await _context.Invitations.FirstOrDefaultAsync(i => i.Id == invitationId);
            if (status == "Accept") 
                invitation.Status = Models.Enum.InvitationStatus.Accepted;
            else if (status == "Decline") 
                invitation.Status = Models.Enum.InvitationStatus.Rejected;
            _context.Invitations.Update(invitation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<ApplicationUser> GetUserById(string userId)
        {
            return await _context.Users.FindAsync(userId);
        }
    }
}
