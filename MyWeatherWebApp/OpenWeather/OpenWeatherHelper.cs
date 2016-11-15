using System;

namespace MyWeatherWebApp.OpenWeather
{
    public class OpenWeatherHelper
    {
        public static WeatherReport GetWeather(string city) 
        {
            var weatherService = new OpenWeatherMapClient();
            var weatherObject = weatherService.GetWeather(city);

            WeatherReport report = new WeatherReport();

            Temperature tempatureInfo = new Temperature();
            tempatureInfo.Current = weatherObject.Result.main.temp;
            tempatureInfo.Low = weatherObject.Result.main.temp_min;
            tempatureInfo.High = weatherObject.Result.main.temp_max;
            report.Temperatures = tempatureInfo;

            report.Pressure = weatherObject.Result.main.pressure;
            report.Humidity = weatherObject.Result.main.humidity;

            Winds wind = new Winds();
            wind.Speed = weatherObject.Result.wind.speed;
            wind.Direction = weatherObject.Result.wind.deg;
            report.Winds = wind;

            report.Description = "Here is today's weather data for " + city + "!";

            return report;
        }
    }
}

