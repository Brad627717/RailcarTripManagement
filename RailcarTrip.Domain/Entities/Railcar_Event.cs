using System.ComponentModel.DataAnnotations.Schema;

namespace RailcarTrip.Domain.Entities
{
    public class Railcar_Event
    {
        public int Id { get; set; }
        [ForeignKey("Railcar")]
        public int RailcarId { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public DateTime EventTime { get; set; }
        [ForeignKey("Trip")]
        public int TripId { get; set; }

        // navigation properties
        public Railcar Railcar { get; set; }
        public Event Event { get; set; }
        public Location Location { get; set; }
        public Trip Trip { get; set; }
    }
}
