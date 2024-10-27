
using Microsoft.EntityFrameworkCore;
using RegistroEventosDeportivos.Domain.Entities;

namespace RegistroEventosDeportivos.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<Athlete> Athletes { get; set; }
    }
}
