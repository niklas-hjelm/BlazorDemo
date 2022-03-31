using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Data
{
    public class HeroContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }

        public HeroContext(DbContextOptions options): base(options)
        {
            
        }
    }
}
