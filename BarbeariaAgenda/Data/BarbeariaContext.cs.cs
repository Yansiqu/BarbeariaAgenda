using Microsoft.EntityFrameworkCore;
using BarbeariaAgenda.Models;

namespace BarbeariaAgenda.Data
{
    public class BarbeariaContext : DbContext
    {
        public BarbeariaContext(DbContextOptions<BarbeariaContext> options)
            : base(options)
        {
        }

        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Barbeiro> Barbeiros { get; set; }
    }
}
