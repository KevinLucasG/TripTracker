using TripTrackerAPI.Dtos;
using TripTrackerAPI.Models;

namespace TripTrackerAPI.Repository.Interface
{
    public interface IItineraries : IBaseRepository
    {
        Task<IEnumerable<ItinerariesDto>> GetItineraries();

        Task <Itineraries> GetItinerariesById(int id);
    }
}
