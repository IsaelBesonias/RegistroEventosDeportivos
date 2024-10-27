
using Microsoft.EntityFrameworkCore;
using RegistroEventosDeportivos.Domain.Entities;

namespace RegistroEventosDeportivos.Infrastructure.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _context;

        public EventRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Event>> GetAllEventsAsync()
        {
            return await _context.Events.Include(e => e.Athletes).ToListAsync();
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _context.Events.Include(e => e.Athletes).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddEventAsync(Event evento)
        {
            await _context.Events.AddAsync(evento);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
