using Microsoft.EntityFrameworkCore;
using PersonajesAPI.Models;

namespace PersonajesAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Personaje> Personajes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personaje>().ToTable("Personajes");
        }
    }
}
