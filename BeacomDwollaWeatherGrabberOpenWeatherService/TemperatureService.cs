using System;
using BeacomDwollaWeatherGrabberInterfaces;

namespace BeacomDwollaWeatherGrabberOpenWeatherService
{
    public class TemperatureService : ITemperatureService
    {
        public TemperatureService()
        {
        }

        public bool CityIsValid(string input)
        {
            //TODO call to api to see if city valid
            return false;
        }

        public float GetTemperatureForCity(string input)
        {
            if(!CityIsValid(input)){throw new ArgumentException("Invalid city input");}
            //TODO call api
            return 33.1f;
        }
    }
}
