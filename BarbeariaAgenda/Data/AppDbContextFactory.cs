using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using BarbeariaAgenda.Models;

namespace BarbeariaAgenda
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Configure aqui sua string de conexão
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BarbeariaAgenda;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
