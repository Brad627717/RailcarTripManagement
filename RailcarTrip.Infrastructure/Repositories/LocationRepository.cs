using Microsoft.EntityFrameworkCore;
using RailcarTrip.Application.Interfaces;
using RailcarTrip.Domain.Entities;
using RailcarTrip.Domain.Enums;
using RailcarTrip.Infrastructure.Context;

namespace RailcarTrip.Infrastructure.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly RailcarDbContext context;
        public LocationRepository(IDbContextFactory<RailcarDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddLocationAsync(Location location)
        {
            context.Locations.Add(location);
            await context.SaveChangesAsync();
        }

        public async Task DeleteLocationByIdAsync(int id)
        {
            var location = await GetLocationByIdAsync(id);
            if (location is not null)
            {
                context.Locations.Remove(location);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Location>> GetAllLocationsAsync()
        {
            var locations = await context.Locations.ToListAsync();
            return locations;
        }

        public async Task<Location?> GetLocationByIdAsync(int id)
        {
            var location = await context.Locations.FirstOrDefaultAsync(e => e.Id == id);
            return location;
        }

        public async Task UpdateLocationAsync(Location location)
        {
            context.Entry(location).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
