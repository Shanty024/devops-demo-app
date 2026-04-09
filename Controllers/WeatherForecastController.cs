using Microsoft.AspNetCore.Mvc;
using DevOpsDemoApp.Interfaces;

namespace DevOpsDemoApp.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _weatherService.GetForecast();
            return Ok(result);
        }
    }
}