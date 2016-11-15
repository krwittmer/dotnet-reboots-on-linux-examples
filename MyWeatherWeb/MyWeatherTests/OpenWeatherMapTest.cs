using MyWeatherWebApi.ApiDataSources;
using Xunit;

namespace MyWeatherTests
{
    public class OpenWeatherMapTest
    {
        [Fact]
        public void WeatherReportTemperatureInExpectedRange()
        {
            string city = "Chicago,IL";
            var reporter = new OpenWeatherReporter();
            var weatherReport = reporter.GetWeather(city);
            double currentTemperature = weatherReport.Temperatures.Current;
            Assert.InRange(currentTemperature, -24, 102);
        }
    }
}
