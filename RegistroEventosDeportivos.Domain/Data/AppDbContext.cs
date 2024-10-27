
using Microsoft.EntityFrameworkCore;
using RegistroEventosDeportivos.Domain.Entities;

namespace RegistroEventosDeportivos.Domain.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}
