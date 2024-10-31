using TripTrackerAPI.Context;
using TripTrackerAPI.Models;
using TripTrackerAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using TripTrackerAPI.Dtos;

namespace TripTrackerAPI.Repository
{
    public class ItinerariesRepository : BaseRepository, IItineraries
    {
        public readonly TripTrackerContext _context;

        public ItinerariesRepository(TripTrackerContext context) : base(context) 
        {
            _context = context;
        }

        public Task<IEnumerable<ItinerariesDto>> GetItineraries()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ItinerariesDto>> GetItinerariesAsync()
        {
            return await _context.Itineraries.Select(X => new ItinerariesDto { Id = X.Id, title = X.title }).ToListAsync();
        }

        public async Task<Itineraries> GetItinerariesById(int id)
        {
            return await _context.Itineraries
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }

   
    }
}
