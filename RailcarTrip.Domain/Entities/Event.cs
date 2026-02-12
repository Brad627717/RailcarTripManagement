namespace RailcarTrip.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // navigation properties
        public ICollection<Railcar_Event> Railcar_Events { get; set; } = new List<Railcar_Event>();
    }
}
