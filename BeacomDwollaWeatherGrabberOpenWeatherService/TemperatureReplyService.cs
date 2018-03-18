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
                var cityIsValid = _temperatureRetrievalService.CityIsValid(input);
                if (!cityIsValid)
                {
                    return String.Format("Sorry, {0} is not a valid city", input);
                }
                var temperature = _temperatureRetrievalService.GetTemperatureForCity(input);
                return String.Format("Temperature for {0} is {1}", input, temperature);
            }
        }
    }
}