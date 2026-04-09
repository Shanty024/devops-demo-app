using DevOpsDemoApp.Models;
using DevOpsDemoApp.Interfaces;

namespace DevOpsDemoApp.Services
{
    public class WeatherService : IWeatherService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Chilly", "Warm", "Hot"
        };

        public IEnumerable<WeatherForecast> GetForecast()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-10, 40),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
        }
    }
}