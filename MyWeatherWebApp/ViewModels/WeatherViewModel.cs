using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyWeatherWebApp.OpenWeather;

namespace MyWeatherWebApp.ViewModels
{
    public class WeatherViewModel
    {
        public Temperature Temperature;
        
        public double Pressure { get; set; }

        public double Humidity { get; set; }

        public Winds Wind { get; set; }

        public string SummaryDescription { get; set; }

        public string SelectedCity { get; set; }

        public List<SelectListItem> Cities { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Chicago, IL", Text = "Chicago" },
            new SelectListItem { Value = "Detroit, MI", Text = "Detroit" },
            new SelectListItem { Value = "Seattle, WA", Text = "Seattle"  },
        };
    }
}
