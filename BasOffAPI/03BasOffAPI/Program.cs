using _03BasOffAPI.ServiceRegistry;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
DBRegistry.RegisterDB(builder.Services);
RepoRegistry.RegisterRepo(builder.Services);
ServiceRegistry.RegisterServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
