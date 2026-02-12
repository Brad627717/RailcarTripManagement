using Microsoft.EntityFrameworkCore;
using RailcarTrip.Domain.Entities;

namespace RailcarTrip.Infrastructure.Context
{
    public class RailcarDbContext : DbContext
    {
        public RailcarDbContext(DbContextOptions<RailcarDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Railcar>().HasData(
                new Railcar { Id = 1, Code = "ACAR1234" },
                new Railcar { Id = 2, Code = "BCAR4321" },
                new Railcar { Id = 3, Code = "CCAR1111" }
            );

            modelBuilder.Entity<Event>().HasData(
                new Event { Id = 1, Code = "W", Description = "Released from origin" },
                new Event { Id = 2, Code = "A", Description = "Arrived at location" },
                new Event { Id = 3, Code = "D", Description = "Departed from location" },
                new Event { Id = 4, Code = "Z", Description = "Placed at Destination" }
            );

            modelBuilder.Entity<Location>().HasData(
                new Location { Id = 1, Name = "Vancouver", Timezone = "Pacific Standard Time" },
                new Location { Id = 2, Name = "Victoria", Timezone = "Pacific Standard Time" },
                new Location { Id = 3, Name = "Kelowna", Timezone = "Pacific Standard Time" },
                new Location { Id = 4, Name = "Kamloops", Timezone = "Pacific Standard Time" },
                new Location { Id = 5, Name = "Prince George", Timezone = "Pacific Standard Time" },
                new Location { Id = 6, Name = "Calgary", Timezone = "Mountain Standard Time" },
                new Location { Id = 7, Name = "Edmonton", Timezone = "Mountain Standard Time" },
                new Location { Id = 8, Name = "Lethbridge", Timezone = "Mountain Standard Time" },
                new Location { Id = 9, Name = "Red Deer", Timezone = "Mountain Standard Time" },
                new Location { Id = 10, Name = "Fort McMurray", Timezone = "Mountain Standard Time" },
                new Location { Id = 11, Name = "Regina", Timezone = "Canada Central Standard Time" },
                new Location { Id = 12, Name = "Saskatoon", Timezone = "Canada Central Standard Time" },
                new Location { Id = 13, Name = "Moose Jaw", Timezone = "Canada Central Standard Time" },
                new Location { Id = 14, Name = "Brandon", Timezone = "Central Standard Time" },
                new Location { Id = 15, Name = "Winnipeg", Timezone = "Central Standard Time" },
                new Location { Id = 16, Name = "Thunder Bay", Timezone = "Eastern Standard Time" },
                new Location { Id = 17, Name = "Sault Ste. Marie", Timezone = "Eastern Standard Time" },
                new Location { Id = 18, Name = "Sudbury", Timezone = "Eastern Standard Time" },
                new Location { Id = 19, Name = "North Bay", Timezone = "Eastern Standard Time" },
                new Location { Id = 20, Name = "Barrie", Timezone = "Eastern Standard Time" },
                new Location { Id = 21, Name = "Toronto", Timezone = "Eastern Standard Time" },
                new Location { Id = 22, Name = "Mississauga", Timezone = "Eastern Standard Time" },
                new Location { Id = 23, Name = "Hamilton", Timezone = "Eastern Standard Time" },
                new Location { Id = 24, Name = "London", Timezone = "Eastern Standard Time" },
                new Location { Id = 25, Name = "Kitchener", Timezone = "Eastern Standard Time" },
                new Location { Id = 26, Name = "Windsor", Timezone = "Eastern Standard Time" },
                new Location { Id = 27, Name = "St Catherines", Timezone = "Eastern Standard Time" },
                new Location { Id = 28, Name = "Oshawa", Timezone = "Eastern Standard Time" },
                new Location { Id = 29, Name = "Kingston", Timezone = "Eastern Standard Time" },
                new Location { Id = 30, Name = "Ottowa", Timezone = "Eastern Standard Time" },
                new Location { Id = 31, Name = "Gattineau", Timezone = "Eastern Standard Time" },
                new Location { Id = 32, Name = "Montreal", Timezone = "Eastern Standard Time" },
                new Location { Id = 33, Name = "Quebec City", Timezone = "Eastern Standard Time" },
                new Location { Id = 34, Name = "Sherbrooke", Timezone = "Eastern Standard Time" },
                new Location { Id = 35, Name = "Trois-RiviÃ¨res", Timezone = "Eastern Standard Time" },
                new Location { Id = 36, Name = "Saguenay", Timezone = "Eastern Standard Time" },
                new Location { Id = 37, Name = "Rimouski", Timezone = "Eastern Standard Time" },
                new Location { Id = 38, Name = "Edmundston", Timezone = "Atlantic Standard Time" },
                new Location { Id = 39, Name = "Fredericton", Timezone = "Atlantic Standard Time" },
                new Location { Id = 40, Name = "Moncton", Timezone = "Atlantic Standard Time" },
                new Location { Id = 41, Name = "Saint John", Timezone = "Atlantic Standard Time" },
                new Location { Id = 42, Name = "Bathurst", Timezone = "Atlantic Standard Time" },
                new Location { Id = 43, Name = "Charlottetown", Timezone = "Atlantic Standard Time" },
                new Location { Id = 44, Name = "Summerside", Timezone = "Atlantic Standard Time" },
                new Location { Id = 45, Name = "Sydney", Timezone = "Atlantic Standard Time" },
                new Location { Id = 46, Name = "Turo", Timezone = "Atlantic Standard Time" },
                new Location { Id = 47, Name = "New Glasgow", Timezone = "Atlantic Standard Time" },
                new Location { Id = 48, Name = "Dartmouth", Timezone = "Atlantic Standard Time" },
                new Location { Id = 49, Name = "Halifax", Timezone = "Atlantic Standard Time" }
            );
        }

        public DbSet<Railcar> Railcars { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Railcar_Event> Railcar_Events { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
