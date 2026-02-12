using System.ComponentModel.DataAnnotations.Schema;

namespace RailcarTrip.Domain.Entities
{
    public class Trip
    {
        public int Id { get; set; }
        [ForeignKey("Railcar")]
        public int RailcarId { get; set; }
        [ForeignKey("Location")]
        public int OriginId { get; set; }
        [ForeignKey("Location")]
        public int? DestinationId { get; set; }
        public DateTime StartUTC { get; set; }
        public DateTime? EndUTC { get; set; }
        public int? DurationMinutes { get; set; }

        // navigation properties
        public ICollection<Railcar_Event> Events { get; set; } = new List<Railcar_Event>();
        public Railcar Railcar { get; set; }
        public Location Origin { get; set; }
        public Location Destination { get; set; }
    }
}
