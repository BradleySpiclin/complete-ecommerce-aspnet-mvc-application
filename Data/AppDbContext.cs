using eGameStore.Models;
using Microsoft.EntityFrameworkCore;

namespace eGameStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developer { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
    }
}
