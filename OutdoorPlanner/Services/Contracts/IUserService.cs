﻿using OutdoorPlanner.Models;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Services.Contracts
{
    public interface IUserService
    {
        public Task<ApplicationUser> GetUserById(string userId);
        public Task<string> GetUserIdByEventId(int eventId);
        public Task<List<InvitationViewModel>> GetUserInvitations(string userId);
        public Task<bool> UpdateUserInvitation(int invitationId, string status);
    }
}
