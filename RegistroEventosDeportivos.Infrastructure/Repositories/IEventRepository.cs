
using RegistroEventosDeportivos.Domain.Entities;

namespace RegistroEventosDeportivos.Infrastructure.Repositories
{
    public interface IEventRepository
    {
        Task<List<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIdAsync(int id);
        Task AddEventAsync(Event evento);
        Task SaveChangesAsync();
    }
}
