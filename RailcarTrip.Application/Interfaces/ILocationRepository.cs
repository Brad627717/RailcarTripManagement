using RailcarTrip.Domain.Entities;

namespace RailcarTrip.Application.Interfaces
{
    public interface ILocationRepository
    {
        Task AddLocationAsync(Location location);

        Task<List<Location>> GetAllLocationsAsync();

        Task<Location?> GetLocationByIdAsync(int id);

        Task UpdateLocationAsync(Location location);

        Task DeleteLocationByIdAsync(int id);
    }
}
