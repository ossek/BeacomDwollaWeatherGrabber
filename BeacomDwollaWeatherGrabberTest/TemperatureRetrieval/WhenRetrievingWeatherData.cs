using System;
using Xunit;
using BeacomDwollaWeatherGrabberInterfaces;
using Moq;

namespace BeacomDwollaWeatherGrabberTest
{
    public class WhenRetrievingWeatherData
    {
        public WhenRetrievingWeatherData()
        {
        }

        [Fact]
        public void WhenCityNameIsBad()
        {
            var badCityService = new Mock<ITemperatureService>().Object;
            var badCity = "Cleveland";
            var isCityValid = badCityService.CityIsValid(badCity);
            Assert.False(isCityValid);
        }
    }
}
