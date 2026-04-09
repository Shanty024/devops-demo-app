using DevOpsDemoApp.Models;

namespace DevOpsDemoApp.Interfaces
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetForecast();
    }
}