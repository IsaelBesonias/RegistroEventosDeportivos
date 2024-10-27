
using RegistroEventosDeportivos.Domain.Entities;
using RegistroEventosDeportivos.Infrastructure.Repositories;

namespace RegistroEventosDeportivos.Application.Services
{
    public class EventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<List<Event>> GetAllEventsAsync()
        {
            return await _eventRepository.GetAllEventsAsync();
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _eventRepository.GetEventByIdAsync(id);
        }

        public async Task AddEventAsync(Event evento)
        {
            await _eventRepository.AddEventAsync(evento);
            await _eventRepository.SaveChangesAsync();
        }
    }
}
