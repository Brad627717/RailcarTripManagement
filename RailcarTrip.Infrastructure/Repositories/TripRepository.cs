using Microsoft.EntityFrameworkCore;
using RailcarTrip.Application.Interfaces;
using RailcarTrip.Domain.Entities;
using RailcarTrip.Domain.Enums;
using RailcarTrip.Infrastructure.Context;

namespace RailcarTrip.Infrastructure.Repositories
{
    public class TripRepository : ITripRepository
    {
        private readonly RailcarDbContext context;
        public TripRepository(IDbContextFactory<RailcarDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task<Trip> AddTripAsync(Trip trip)
        {
            context.Trips.Add(trip);
            await context.SaveChangesAsync();
            return trip;
        }

        public async Task DeleteTripByIdAsync(int id)
        {
            var trip = await GetTripByIdAsync(id);
            if (trip is not null)
            {
                context.Trips.Remove(trip);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Trip>> GetAllTripsAsync()
        {
            var trips = await context.Trips
                .Include(t => t.Railcar)
                .Include(t => t.Origin)
                .Include(t => t.Destination)
                .ToListAsync();
            return trips;
        }

        public async Task<Trip?> GetTripByIdAsync(int id)
        {
            var trip = await context.Trips.FirstOrDefaultAsync(e => e.Id == id);
            return trip;
        }

        public async Task UpdateTripAsync(Trip trip)
        {
            context.Entry(trip).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
