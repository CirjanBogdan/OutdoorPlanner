using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Services.Contracts
{
    public interface IUserService
    {
        public Task<string> GetUserIdByEventId(int eventId);
    }
}
