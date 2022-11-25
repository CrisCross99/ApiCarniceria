using Microsoft.AspNetCore.Mvc;

namespace ApiCarniceria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarneController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<CarneController> _logger;

        public CarneController(ILogger<CarneController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Carne")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}