using AutoMapper;
using TripTrackerAPI.Dtos;
using TripTrackerAPI.Models;

namespace TripTrackerAPI.Mapping
{
    public class ItinerarieMap : Profile
    {
        public ItinerarieMap()
        {
            CreateMap<Itineraries, ItinerariesDto>().ReverseMap();

            CreateMap<Itineraries, ItinerarieAddDto>().ReverseMap();
            
        }
    }
}
