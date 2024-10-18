namespace TripTrackerAPI.Dtos
{
    public class ItinerariesDto
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public DateTime date_start { get; set; }
        public DateTime date_end { get; set; }

        public string local_start { get; set; }

        public string local_end { get; set; }
    }
}
