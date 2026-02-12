using RailcarTrip.Domain.Entities;

namespace RailcarTrip.Application.Interfaces
{
    public interface IRailcarEventRepository
    {
        Task AddRailcarEventAsync(Railcar_Event railcarEvent);

        Task<List<Railcar_Event>> GetAllRailcarEventsAsync();

        Task<List<Railcar_Event>> GetRailcarEventsByTripIdAsync(int tripId);

        Task<Railcar_Event?> GetRailcarEventByIdAsync(int id);

        Task UpdateRailcarEventAsync(Railcar_Event railcarEvent);

        Task DeleteRailcarEventByIdAsync(int id);
    }
}
