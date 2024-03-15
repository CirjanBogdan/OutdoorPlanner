using AutoMapper;
using OutdoorPlanner.Data;
using OutdoorPlanner.Models;
using OutdoorPlanner.Services.Contracts;
using OutdoorPlanner.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace OutdoorPlanner.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _eventService;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public EventController(IEventService eventService, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _eventService = eventService;
        }

        public async Task<IActionResult> All(int? pageNumber, string filterByCategory)
        {
            if (filterByCategory != null)
                HttpContext.Session.SetString("filterByCategory", filterByCategory);
            else if (pageNumber is null)
                HttpContext.Session.SetString("filterByCategory", "");

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("filterByCategory")))
                filterByCategory = HttpContext.Session.GetString("filterByCategory");

            // GET FORCAST 
            var forecastResult = await _eventService.GetForcast();
            if (!forecastResult)
                TempData["ErrorMessage"] = "Error getting weather from OpenWeather.";

            var pageSize = 3;
            var events = await _eventService.GetUpcomingEvents(filterByCategory);

            TempData["FilterByCategory"] = filterByCategory;
            
            return View(PaginatedList<EventViewModel>.Create(events, pageNumber ?? 1, pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> PastEvents()
        {
            return View(await _eventService.GetPastEvents());
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEventBindingModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                await _eventService.CreateEvent(model, user.Id);
                TempData["SuccessMessage"] = "Event created successfully.";

                return RedirectToAction("All");
            }
            TempData["ErrorMessage"] = "Failed to create the event.";

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var @event = await _eventService.GetEventById(id);
            var result = _mapper.Map<EventViewModel>(@event);

            return View(result);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Update(int id)
        {
            var @event = await _eventService.GetEventById(id);
            var result = _mapper.Map<EventViewModel>(@event);

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, EventViewModel model)
        {
            var result = await _eventService.UpdateEvent(id, model);

            if (result)
                TempData["SuccessMessage"] = "Event updated successfully.";
            else
                TempData["ErrorMessage"] = "Failed to update the event.";

            return RedirectToAction("All");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var @event = await _eventService.GetEventById(id);
            var result = _mapper.Map<EventViewModel>(@event);

            return View(result);
        }

        [HttpPost] 
        public async Task<IActionResult> Delete(int id, EventViewModel model)
        {
            var result = await _eventService.DeleteEvent(id, model);

            if (result)
                TempData["SuccessMessage"] = "Event deleted successfully.";
            else
                TempData["ErrorMessage"] = "Failed to delete the event.";

            return RedirectToAction("All");
        }
    }
}
