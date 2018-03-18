using System;

namespace BeacomDwollaWeatherGrabberInterfaces
{
    public interface ITemperatureReplyService
    {
        string GetTemperatureReply(string input);
    }
}