
using Microsoft.AspNetCore.Mvc;
using RegistroEventosDeportivos.Application.Services;
using RegistroEventosDeportivos.Domain.Entities;

namespace RegistroEventosDeportivos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventApiController : ControllerBase
    {
        private readonly EventService _eventService;

        public EventApiController(EventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            var events = await _eventService.GetAllEventsAsync();
            return Ok(events);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(Event evento)
        {
            await _eventService.AddEventAsync(evento);
            return CreatedAtAction(nameof(GetEvents), new { id = evento.Id }, evento);
        }
    }
}
