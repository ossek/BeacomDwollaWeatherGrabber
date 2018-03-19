using System;
using BeacomDwollaWeatherGrabberInterfaces;

namespace BeacomDwollaWeatherGrabberOpenWeatherService
{
    public class TemperatureReplyService : ITemperatureReplyService
    {
        private ITemperatureService _temperatureRetrievalService;
        public TemperatureReplyService(ITemperatureService temperatureService)
        {
            this._temperatureRetrievalService = temperatureService;
        }
        public string GetTemperatureReply(string input)
        {
            {
                double temperature;
                try
                {
                    var cityIsValid = _temperatureRetrievalService.CityIsValid(input);
                    if (!cityIsValid)
                    {
                        return String.Format("Sorry, {0} is not a valid city", input);
                    }
                    temperature = _temperatureRetrievalService.GetTemperatureForCity(input);
                }
                catch (Exception e)
                {
                    return String.Format("Sorry, there was a problem getting weather data for {0}", input);
                }
                return String.Format("Temperature for {0} is {1} degrees fahrenheit", input, temperature);
            }
        }
    }
}