global using Microsoft.EntityFrameworkCore;
global using StatusDetails.Model;
global using StatusDetails.Data;
global using StatusDetails.Repository;
global using StatusDetails.Request;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<StatusContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StatusContext")));
builder.Services.AddScoped<IStatusService, StatusService>();

var app = builder.Build();

app.MapGet("/status", async (IStatusService statusService) =>
await statusService.GetStatus());

app.MapGet("/status/{id}", async (int id, IStatusService statusService) =>
await statusService.GetStatusById(id));

app.MapPost("/status", async (StatusRequest statusRequest, IStatusService statusService) =>
await statusService.CreateStatus(statusRequest));

app.MapPut("/status/{id}", async (int id, StatusRequest statusRequest, IStatusService statusService) =>
await statusService.UpdateStatus(id, statusRequest));

app.MapDelete("/status/{id}", async (int id, IStatusService statusService) =>
await statusService.DeleteStatus(id));


app.Run();
