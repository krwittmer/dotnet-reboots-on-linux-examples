using MyWeatherWebApi.Models;
using MyWeatherWebApi.OpenWeather;

namespace MyWeatherWebApi.ApiDataSources
{
    public class OpenWeatherReporter : IWeatherReporter
    {
        public WeatherReport GetWeather(string city) 
        {
            var weatherClient = new OpenWeatherMapClient();
            var weatherObject = weatherClient.GetWeather(city);

            WeatherReport report = new WeatherReport();

            Temperature tempatureInfo = new Temperature
            {
                Current = weatherObject.Result.main.temp,
                Low = weatherObject.Result.main.temp_min,
                High = weatherObject.Result.main.temp_max
            };
            report.Temperatures = tempatureInfo;

            report.Pressure = weatherObject.Result.main.pressure;
            report.Humidity = weatherObject.Result.main.humidity;

            Winds wind = new Winds
            {
                Speed = weatherObject.Result.wind.speed,
                Direction = weatherObject.Result.wind.deg
            };
            report.Winds = wind;

            report.Description = "Here is today's weather data for " + city + "!";

            return report;
        }
    }
}

