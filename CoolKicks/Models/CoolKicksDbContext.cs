using Microsoft.EntityFrameworkCore;

namespace CoolKicks.Models
{
    public class CoolKicksDbContext: DbContext
    {
        public CoolKicksDbContext(DbContextOptions<CoolKicksDbContext> options) : base(options) 
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Sneaker> Sneakers { get; set; }
    }
}
