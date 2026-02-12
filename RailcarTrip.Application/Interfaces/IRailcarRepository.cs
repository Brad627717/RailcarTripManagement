using RailcarTrip.Domain.Entities;

namespace RailcarTrip.Application.Interfaces
{
    public interface IRailcarRepository
    {
        Task AddRailcarAsync(Railcar railcar);

        Task<List<Railcar>> GetAllRailcarsAsync();

        Task<Railcar?> GetRailcarByIdAsync(int id);

        Task<Railcar?> GetRailcarByCodeAsync(string code);

        Task UpdateRailcarAsync(Railcar railcar);

        Task DeleteRailcarByIdAsync(int id);
    }
}
