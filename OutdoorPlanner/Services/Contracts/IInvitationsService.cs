using OutdoorPlanner.Models;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Services.Contracts
{
    public interface IInvitationsService
    {

        public Task<InvitationViewModel> GetInvitationById(int invitationId);
        public Task<bool> DeleteInvitationById(int invitationId);
        public Task<InvitationsEventViewModel> GetInvitationsByEventId(int eventId);
        public Task<bool> CreateInvitationInDb(CreateInvitationBindingModel model);
        public Task<bool> CheckIfInvitationExist(int eventId, string email);
    }
}
