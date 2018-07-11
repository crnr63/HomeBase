using Microsoft.EntityFrameworkCore;

namespace HomeBase.Models
{
    public class RealEstateContext : DbContext
    {
        public RealEstateContext(DbContextOptions<RealEstateContext> options)
            : base(options)
        {
        }
        public DbSet<HomeBase.Models.USAHomeSales> USAHomeSales { get; set; }

    }
}
