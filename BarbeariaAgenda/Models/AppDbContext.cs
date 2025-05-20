using Microsoft.EntityFrameworkCore;

namespace BarbeariaAgenda.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Barbeiro> Barbeiros { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}
