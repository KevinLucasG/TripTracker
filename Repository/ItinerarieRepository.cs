using TripTrackerAPI.Context;
using TripTrackerAPI.Models;
using TripTrackerAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using TripTrackerAPI.Dtos;

namespace TripTrackerAPI.Repository
{
    public class ItinerarieRepository : BaseRepository
    {
        public readonly TripTrackerContext _context;

        public ItinerarieRepository(TripTrackerContext context) : base(context) 
        {
            _context = context;
        }
        public async Task<IEnumerable<ItinerariesDto>> GetItinerariesAsync()
        {
            return await _context.Itineraries.Select(X => new ItinerariesDto { Id = X.Id, title = X.title }).ToListAsync();
        }

        public async Task<Itineraries> GetItinerariesByIdAsync(int id)
        {
            return await _context.Itineraries
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
