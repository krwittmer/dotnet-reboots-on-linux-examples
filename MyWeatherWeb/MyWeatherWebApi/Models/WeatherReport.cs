using System;

namespace MyWeatherWebApi.Models
{
    public class WeatherReport
    {
        public DateTime Timestamp { get; set; }

        public Temperature Temperatures { get; set; }

        public double Pressure { get; set; }

        public double Humidity { get; set; }

        public Winds Winds { get; set; }
        public string Description { get; set; }
    }
}
