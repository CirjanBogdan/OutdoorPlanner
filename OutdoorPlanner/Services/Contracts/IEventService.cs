using OutdoorPlanner.Models;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Services.Contracts
{
    public interface IEventService
    {
        Task<List<EventViewModel>> GetUpcomingEvents(string filterByCategory);
        Task<List<EventViewModel>> GetPastEvents();
        Task<Event> GetEventById(int id);
        Task<bool> CreateEvent(CreateEventBindingModel @event, string userId);
        Task<bool> UpdateEvent(int id, EventViewModel model);
        Task<bool> DeleteEvent(int id);
        Task<bool> GetForcast();
        
    }
}
