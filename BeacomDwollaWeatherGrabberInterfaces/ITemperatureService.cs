using System;

namespace BeacomDwollaWeatherGrabberInterfaces
{
    public interface ITemperatureService
    {
        bool CityIsValid(string input);
        float GetTemperatureForCity(string input);
    }
}
