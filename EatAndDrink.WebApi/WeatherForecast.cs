using System;
using EatAndDrink.Repository.Data;

namespace EatAndDrink.WebApi
{
    public class WeatherForecast
    {
        public WeatherForecast()
        {

        }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }






    }





}
