using Microsoft.EntityFrameworkCore;

namespace HomeBase.Models
{
    public class QOTDContext : DbContext
    {
        public QOTDContext (DbContextOptions<QOTDContext> options)
            : base(options)
        {
        }
        public DbSet<HomeBase.Models.ParticipantQOTD> ParticipantQOTD  { get; set; }
        public DbSet<HomeBase.Models.QOTDAnswer> QOTDAnswer { get; set; }

        public DbSet<HomeBase.Models.QOTD> QOTD { get; set; }
    }
}
