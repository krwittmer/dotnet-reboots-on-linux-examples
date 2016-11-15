using System;

namespace MyWeatherWebApp.OpenWeather
{

    public struct Temperature
    {
        public double Current;
        public double High;

        public double Low;

    }

    public struct Winds
    {
        public double Speed;
        public double Direction;
    }

    public struct WeatherReport
    {
        public DateTime Timestamp;

        public Temperature Temperatures;

        public double Pressure;

        public double Humidity;

        public Winds Winds;
        public string Description;
    }

}