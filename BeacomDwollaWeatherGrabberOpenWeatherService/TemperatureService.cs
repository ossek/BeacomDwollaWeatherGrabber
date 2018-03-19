using System;
using BeacomDwollaWeatherGrabberInterfaces;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace BeacomDwollaWeatherGrabberOpenWeatherService
{
    public class TemperatureService : ITemperatureService
    {
        public TemperatureService()
        {
        }

        //a little redundant to call this twice, but didn't see a GetCity type api call...
        public bool CityIsValid(string city)
        {
            HttpClient client = new HttpClient();
            var apikey = "d773b609a835cde212c77abcc8bfa6ae";
            var url = string.Format(
                "http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}"
                , city, apikey);
            var result = client.GetAsync(url).Result;
            if (result.StatusCode == HttpStatusCode.OK) return true;
            if (result.StatusCode == HttpStatusCode.NotFound) return false;
            throw new ArgumentException("Something went wrong trying to call Open Weather Api");
        }

        public double GetTemperatureForCity(string city)
        {
            HttpClient client = new HttpClient();
            var apikey = "d773b609a835cde212c77abcc8bfa6ae";
            var url = string.Format(
                "http://api.openweathermap.org/data/2.5/weather?q={0}&units=imperial&APPID={1}"
                , city, apikey);
            //a TODO would be to either find an actual sync library or make these methods async
            var result = client.GetAsync(url).Result;
            var resultString = result.Content.ReadAsStringAsync().Result;
            var example = new
            {
                coord = new { lon = -0.13, lat = 51.51 },
                weather = new[] { new { id = 600, main = "Snow", description = "light snow", icon = "13n" } },
                //base = "stations",
                main = new { temp = 272.04, pressure = 1011, humidity = 86, temp_min = 271.15, temp_max = 273.15 },
                visibility = 3000,
                wind = new { speed = 5.1, deg = 50 },
                clouds = new { all = 75 },
                dt = 1521406200,
                sys = new { type = 1, id = 5168, message = 0.006, country = "GB", sunrise = 1521353163, sunset = 1521396692 },
                id = 2643743,
                name = "London",
                cod = 200
            };
            var deserialized = JsonConvert.DeserializeAnonymousType(resultString,example);
            return deserialized.main.temp;
        }
    }
}
