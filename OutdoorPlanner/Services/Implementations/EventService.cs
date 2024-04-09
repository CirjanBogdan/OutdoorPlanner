using AutoMapper;
using OutdoorPlanner.Data;
using OutdoorPlanner.Models;
using OutdoorPlanner.Models.Enum;
using OutdoorPlanner.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.Services.Implementations
{
    public class EventService : IEventService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public EventService(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<EventViewModel>> GetUpcomingEvents(string filterByCategory)
        {
            Enum.TryParse(filterByCategory, out Category enumEventCategory);
            var upcomingEvents = await _context.Events.Where(e => (filterByCategory == null || e.Category == enumEventCategory) && e.Date > DateTime.Now)
                                                      .OrderBy(d => d.Date).ToListAsync();

            return _mapper.Map<List<EventViewModel>>(upcomingEvents);
        }

        public async Task<List<EventViewModel>> GetPastEvents()
        {
            var pastEvents = await _context.Events.Where(e => e.Date < DateTime.Now).OrderBy(d => d.Date).ToListAsync();

            return _mapper.Map<List<EventViewModel>>(pastEvents);
        }

        public async Task<bool> CreateEvent(CreateEventBindingModel model, string userId)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                var newEvent = _mapper.Map<Event>(model);

                newEvent.User = user;
                newEvent.UserId = user.Id;

                _context.Events.Add(newEvent);
                _context.Users.Update(user);

                var invitation = new Invitation()
                {
                    EventId = model.Id,
                    Event = newEvent,
                    UserEmail = user.Email,
                    Status = InvitationStatus.Accepted,
                };
                var autoInvite = await _context.Invitations.AddAsync(invitation);
                await _context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteEvent(int id)
        {
            try
            {
                var @event = _context.Events.FirstOrDefault(e => e.Id == id);
                _context.Events.Remove(@event);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<Event> GetEventById(int id)
        {
            return await _context.Events.FindAsync(id);
        }

        public async Task<bool> UpdateEvent(int id, EventViewModel model)
        {
            try
            {
                var @event = await _context.Events.FindAsync(id);
                @event = _mapper.Map<Event>(model);
                _context.Events.Update(@event);
                await _context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> GetForcast()
        {
            var currentDate = DateTime.Now;
            // Get upcoming events and sort them
            var upcomingEvents = await _context.Events.Where(e => e.Date > currentDate).Where(e => e.Forcasted == false)
                                                      .Where(e => e.Date < currentDate.AddDays(4))
                                                      .OrderBy(d => d.Date).ToListAsync();
            foreach (var @event in upcomingEvents)
            {
                using (var client = new HttpClient())
                {
                    try
                    {
                        client.BaseAddress = new Uri("http://api.openweathermap.org");
                        var response = await client.GetAsync($"/data/2.5/forecast?q={@event.City}&appid=4b1193b7a1b0d76242d575f938202e33&units=metric");
                        response.EnsureSuccessStatusCode();

                        var stringResult = await response.Content.ReadAsStringAsync();
                        var rawWeather = JsonConvert.DeserializeObject<RootObject>(stringResult);
                        if (rawWeather != null)
                        {
                            var eventDateAndHour = @event.Date;
                            foreach (var forecast in rawWeather.List)
                            {
                                if (eventDateAndHour < forecast.Dt_Txt)
                                {
                                    var rain = forecast.Rain;
                                    if (rain != null)
                                        @event.Rain = true;
                                    @event.Temperature = (int)forecast.Main.Temp;
                                    @event.CloudsValue = forecast.Clouds.All;
                                    @event.Forcasted = true;
                                    break;
                                }
                            }
                        }
                        _context.Events.Update(@event);
                        await _context.SaveChangesAsync();
                    }
                    catch (HttpRequestException)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
