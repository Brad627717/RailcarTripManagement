using Microsoft.EntityFrameworkCore;
using RailcarTrip.Application.Interfaces;
using RailcarTrip.Domain.Entities;
using RailcarTrip.Domain.Enums;
using RailcarTrip.Infrastructure.Context;

namespace RailcarTrip.Infrastructure.Repositories
{
    public class RailcarEventRepository : IRailcarEventRepository
    {
        private readonly RailcarDbContext context;
        public RailcarEventRepository(IDbContextFactory<RailcarDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddRailcarEventAsync(Railcar_Event railcarEvent)
        {
            context.Railcar_Events.Add(railcarEvent);
            await context.SaveChangesAsync();
        }

        public async Task DeleteRailcarEventByIdAsync(int id)
        {
            var railcarEvent = await GetRailcarEventByIdAsync(id);
            if (railcarEvent is not null)
            {
                context.Railcar_Events.Remove(railcarEvent);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Railcar_Event>> GetAllRailcarEventsAsync()
        {
            var railcarEvents = await context.Railcar_Events.ToListAsync();
            return railcarEvents;
        }

        public async Task<List<Railcar_Event>> GetRailcarEventsByTripIdAsync(int tripId)
        {
            var railcarEvents = await context.Railcar_Events
                .Where(e => e.TripId == tripId)
                .Include(e => e.Railcar)
                .Include(e => e.Location)
                .Include(e => e.Event)
                .ToListAsync();
            return railcarEvents;
        }

        public async Task<Railcar_Event?> GetRailcarEventByIdAsync(int id)
        {
            var railcarEvent = await context.Railcar_Events.FirstOrDefaultAsync(e => e.Id == id);
            return railcarEvent;
        }

        public async Task UpdateRailcarEventAsync(Railcar_Event railcarEvent)
        {
            context.Entry(railcarEvent).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
