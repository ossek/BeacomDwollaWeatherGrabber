using System;
using BeacomDwollaWeatherGrabberInterfaces;
using BeacomDwollaWeatherGrabberOpenWeatherService;

namespace BeacomDwollaWeatherGrabberCli
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //pretend for a sec we can use ctrl-c
            while (true)
            {
                Console.Write("Type a city name to get current temperature: ");
                var input = Console.ReadLine();
                var temperatureService = new TemperatureService();
                var temperatureReplyService = new TemperatureReplyService(temperatureService);
                Console.WriteLine(temperatureReplyService.GetTemperatureReply(input));
            }
        }

   }
}
