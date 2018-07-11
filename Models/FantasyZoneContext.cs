using Microsoft.EntityFrameworkCore;

namespace HomeBase.Models
{
    public class FantasyZoneContext : DbContext
    {
        public FantasyZoneContext(DbContextOptions<FantasyZoneContext> options)
            : base(options)
        {
          
        }
        public DbSet<HomeBase.Models.FantasyWeekGames> FantasyWeekGames  { get; set; }

    
    
    }
}

