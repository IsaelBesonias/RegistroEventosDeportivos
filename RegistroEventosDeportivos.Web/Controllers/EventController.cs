
using Microsoft.AspNetCore.Mvc;
using RegistroEventosDeportivos.Application.Services;
using RegistroEventosDeportivos.Domain.Entities;

namespace RegistroEventosDeportivos.Web.Controllers
{
    public class EventController : Controller
    {
        private readonly EventService _eventService;

        public EventController(EventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _eventService.GetAllEventsAsync();
            return View(events);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Event evento)
        {
            if (ModelState.IsValid)
            {
                await _eventService.AddEventAsync(evento);
                return RedirectToAction(nameof(Index));
            }
            return View(evento);
        }
    }
}
