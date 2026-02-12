using Microsoft.EntityFrameworkCore;
using RailcarTrip.Application.Interfaces;
using RailcarTrip.Domain.Entities;
using RailcarTrip.Domain.Enums;
using RailcarTrip.Infrastructure.Context;

namespace RailcarTrip.Infrastructure.Repositories
{
    public class RailcarRepository : IRailcarRepository
    {
        private readonly RailcarDbContext context;
        public RailcarRepository(IDbContextFactory<RailcarDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddRailcarAsync(Railcar railcar)
        {
            context.Railcars.Add(railcar);
            await context.SaveChangesAsync();
        }

        public async Task DeleteRailcarByIdAsync(int id)
        {
            var railcar = await GetRailcarByIdAsync(id);
            if (railcar is not null)
            {
                context.Railcars.Remove(railcar);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Railcar>> GetAllRailcarsAsync()
        {
            var railcars = await context.Railcars.ToListAsync();
            return railcars;
        }

        public async Task<Railcar?> GetRailcarByCodeAsync(string code)
        {
            var railcar = await context.Railcars.Where(e => e.Code == code).FirstOrDefaultAsync();
            return railcar;
        }

        public async Task<Railcar?> GetRailcarByIdAsync(int id)
        {
            var railcar = await context.Railcars.FirstOrDefaultAsync(e => e.Id == id);
            return railcar;
        }

        public async Task UpdateRailcarAsync(Railcar railcar)
        {
            context.Entry(railcar).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
