using RailcarTrip.Domain.Entities;

namespace RailcarTrip.Application.Interfaces
{
    public interface ITripRepository
    {
        Task<Trip> AddTripAsync(Trip trip);

        Task<List<Trip>> GetAllTripsAsync();

        Task<Trip?> GetTripByIdAsync(int id);

        Task UpdateTripAsync(Trip trip);

        Task DeleteTripByIdAsync(int id);
    }
}
