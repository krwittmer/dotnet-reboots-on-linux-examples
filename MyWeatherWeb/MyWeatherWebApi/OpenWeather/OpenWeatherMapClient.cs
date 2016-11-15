using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyWeatherWebApi.OpenWeather
{
	/**
	 * This class was derived from the example that Nick Landry and James Montomagno developed to 
	 * demonstrate the Mono-based Xaramin cross platform mobile development framework. Thank you
	 * Nick and James!
	 */
    class OpenWeatherMapClient
    {
        private const string APIKey = "REGISTER_AND_INSERT_YOUR_OWN_OWM_API_KEY"; // register at openweathermap.org
        private const string APIUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&units=imperial&APPID=" + APIKey;

        public async Task<WeatherRoot> GetWeather(string location)
        {
            var url = string.Format(APIUrl, location);
            string json = String.Empty;

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                json = content.ReadAsStringAsync().Result;

                if (string.IsNullOrWhiteSpace(json))
                    return null;

            }
            return JsonConvert.DeserializeObject<WeatherRoot>(json);
        }
    }
}
