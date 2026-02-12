using Microsoft.EntityFrameworkCore;
using RailcarTrip.Application.Interfaces;
using RailcarTrip.Domain.Entities;
using RailcarTrip.Infrastructure.Context;

namespace RailcarTrip.Infrastructure.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly RailcarDbContext context;
        public EventRepository(IDbContextFactory<RailcarDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task<Event> AddEventAsync(Event eventModel)
        {
            context.Events.Add(eventModel);
            await context.SaveChangesAsync();
            return eventModel;
        }

        public async Task DeleteEventByIdAsync(int id)
        {
            var eventModel = await GetEventByIdAsync(id);
            if (eventModel is not null)
            {
                context.Events.Remove(eventModel);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Event>> GetAllEventsAsync()
        {
            var eventModels = await context.Events.ToListAsync();
            return eventModels;
        }

        public async Task<Event?> GetEventByCodeAsync(string code)
        {
            var eventModel = await context.Events.Where(e => e.Code == code).FirstOrDefaultAsync();
            return eventModel;
        }

        public async Task<Event?> GetEventByIdAsync(int id)
        {
            var eventModel = await context.Events.FirstOrDefaultAsync(e => e.Id == id);
            return eventModel;
        }

        public async Task UpdateEventAsync(Event eventModel)
        {
            context.Entry(eventModel).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
