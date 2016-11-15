using MyWeatherWebApi.Models;

namespace MyWeatherWebApi.ApiDataSources
{
    public interface IWeatherReporter
    {
        WeatherReport GetWeather(string city);
    }
}