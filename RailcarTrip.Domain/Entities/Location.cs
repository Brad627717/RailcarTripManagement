using System.ComponentModel.DataAnnotations.Schema;

namespace RailcarTrip.Domain.Entities
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Timezone { get; set; } = string.Empty;

        // navigation properties
        public ICollection<Railcar_Event> Railcar_Events { get; set; } = new List<Railcar_Event>();
    }
}
