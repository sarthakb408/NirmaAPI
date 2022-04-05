global using Microsoft.EntityFrameworkCore;
global using TerminalDetails.Data;
global using TerminalDetails.Model;
global using TerminalDetails.Repository;
global using TerminalDetails.Request;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TerminalContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TerminalContext")));
builder.Services.AddScoped<ITerminalService, TerminalService>();
var app = builder.Build();

app.MapGet("/terminals", async (ITerminalService terminalService) =>
await terminalService.GetTerminals());

app.MapGet("/terminals/{id}", async (int id, ITerminalService terminalService) =>
await terminalService.GetTerminalById(id));

app.MapPost("/terminals", async (TerminalRequest terminalRequest, ITerminalService terminalService) =>
await terminalService.CreateTerminal(terminalRequest));

app.MapPut("/terminals/{id}", async (int id, TerminalRequest terminalRequest, ITerminalService terminalService) =>
await terminalService.UpdateTerminal(id, terminalRequest));

app.MapDelete("/articles/{id}", async (int id, ITerminalService terminalService) =>
await terminalService.DeleteTerminal(id));

app.Run();
