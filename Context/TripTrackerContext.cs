using Microsoft.EntityFrameworkCore;
using TripTrackerAPI.Models;

namespace TripTrackerAPI.Context
{
    public class TripTrackerContext : DbContext
    {
        
        public TripTrackerContext(DbContextOptions<TripTrackerContext> options) : base (options)
        { }

        public DbSet<Itineraries> Itineraries { get; set; }



    }
}
