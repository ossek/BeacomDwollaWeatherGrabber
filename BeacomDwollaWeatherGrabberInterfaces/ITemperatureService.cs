using System;

namespace BeacomDwollaWeatherGrabberInterfaces
{
    public interface ITemperatureService
    {
        bool CityIsValid(string input);
        double GetTemperatureForCity(string input);
    }
}
