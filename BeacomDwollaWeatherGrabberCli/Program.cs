using System;

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
                var temperatureRetrievalService = new TemperatureRetrievalService()
                var temperature = temperatureRetrievalService.GetTemperatureForCity(input);
                Console.WriteLine(String.Format("Temperature for {0} is {1}", input, temperature);
            }
        }
    }
}
