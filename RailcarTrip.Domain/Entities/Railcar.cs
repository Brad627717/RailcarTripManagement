using System.ComponentModel.DataAnnotations;

namespace RailcarTrip.Domain.Entities
{
    public class Railcar
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;

        // navigation properties
        public ICollection<Railcar_Event> Events { get; set; } = new List<Railcar_Event>();
    }
}
