using DevOpsDemoApp.Interfaces;
using DevOpsDemoApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

// Dependency Injection
builder.Services.AddSingleton<IWeatherService, WeatherService>();

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();