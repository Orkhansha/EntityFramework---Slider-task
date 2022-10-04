using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;


namespace EntityFramework.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }

    }
}
