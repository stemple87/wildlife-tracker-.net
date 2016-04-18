using Microsoft.Data.Entity;

namespace wildlife_tracker.Models
{
    public class WildlifeTrackerContext : DbContext
    {
        public virtual DbSet<Animal> Animals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=wildlife_tracker;integrated security = True");
        }
    }
}