using Microsoft.EntityFrameworkCore;
using RailcarTrip.Application.Interfaces;
using RailcarTrip.Components;
using RailcarTrip.Infrastructure.Context;
using RailcarTrip.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<RailcarDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RailcarDbConnection"));
});

builder.Services.AddScoped<IRailcarEventRepository, RailcarEventRepository>();
builder.Services.AddScoped<IRailcarRepository, RailcarRepository>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<ITripRepository, TripRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
