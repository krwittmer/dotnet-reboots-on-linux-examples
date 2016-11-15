using Microsoft.AspNetCore.Mvc;
using MyWeatherWebApp.ViewModels;
using MyWeatherWebApp.OpenWeather;

namespace MyWeatherWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(WeatherViewModel model)
        {
            var weather = new WeatherViewModel();

            if (ModelState.IsValid)
            {
                if (model.SelectedCity != null)
                {
                    var weatherReport = OpenWeatherHelper.GetWeather(model.SelectedCity);
                    weather.Temperature = weatherReport.Temperatures;
                    weather.Pressure = weatherReport.Pressure;
                    weather.Humidity = weatherReport.Humidity;
                    weather.Wind = weatherReport.Winds;
                    weather.SummaryDescription = weatherReport.Description;
                }
            }

            return View(weather);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
