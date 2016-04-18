using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wildlife_tracker.Models
{
    public class WildlifeTrackerContext : DbContext
    {
        public virtual DbSet<Animal> Animals { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb\mssqllocaldb;Database=wildlife_tracker;intergrated security = True");
        }
    }
}
