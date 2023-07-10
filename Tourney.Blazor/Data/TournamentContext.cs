using Microsoft.EntityFrameworkCore;

namespace Tourney.Blazor.Data
{
    public class TournamentContext : DbContext
    {
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
