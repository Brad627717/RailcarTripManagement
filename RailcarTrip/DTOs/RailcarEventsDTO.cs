using CsvHelper.Configuration.Attributes;

namespace RailcarTrip.DTOs
{
    public class RailcarEventsDTO
    {
        [Name("Equipment Id")]
        public string RailcarCode { get; set; }
        [Name("Event Code")]
        public string EventCode { get; set; }
        [Name("Event Time")]
        [Format("yyyy-MM-dd HH:mm")]
        public DateTime EventTime { get; set; }
        [Name("City Id")]
        public int LocationId { get; set; }

        public string PrintValues()
        {
            return $"RailcarEvent (RailcarCode: {RailcarCode}, EventCode: {EventCode}, EventTime: {EventTime}, LocationId: {LocationId})";
        }
    }
}
