using ASP.NETCoreVoya.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreVoya.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Destino> Destino { get; set; }
        public DbSet<Promocao> Promocao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}

