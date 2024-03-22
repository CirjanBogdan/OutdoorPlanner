using AutoMapper;
using Microsoft.AspNetCore.Identity;
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
    }
}
