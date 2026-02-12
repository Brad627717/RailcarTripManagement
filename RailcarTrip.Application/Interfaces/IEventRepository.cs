using RailcarTrip.Domain.Entities;

namespace RailcarTrip.Application.Interfaces
{
    public interface IEventRepository
    {
        Task<Event> AddEventAsync(Event eventModel);

        Task<List<Event>> GetAllEventsAsync();

        Task<Event?> GetEventByIdAsync(int id);

        Task<Event?> GetEventByCodeAsync(string code);

        Task UpdateEventAsync(Event eventModel);

        Task DeleteEventByIdAsync(int id);
    }
}
