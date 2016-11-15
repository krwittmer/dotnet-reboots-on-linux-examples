using Microsoft.AspNetCore.Mvc;
using MyWeatherWebApi.ApiDataSources;

namespace MyWeatherWebApi.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        [HttpGet("temperature/{cityLocation}")]
        public IActionResult Get(string cityLocation)
        {
            var reporter = new OpenWeatherReporter();
	        var weatherReport = reporter.GetWeather(cityLocation);
            return new ObjectResult(weatherReport.Temperatures);
        }
   }
}
