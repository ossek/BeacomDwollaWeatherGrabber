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
        public void WhenTemperatureRetrievableThenReturnTemperature()
        {
            Assert.False(true);
        }

        [Fact]
        public void WhenConnectionNotAvailableThenThrowException()
        {
            Assert.False(true);
        }

        
    }

    public class WhenCheckingCityName
    {
        [Fact]
        public void WhenCityNameNotFoundBadThenReturnFalse()
        {
            var badCityService = new Mock<ITemperatureService>().Object;
            var badCity = "Cleveland";
            var isCityValid = badCityService.CityIsValid(badCity);
            Assert.False(isCityValid);
        }

        [Fact]
        public void WhenCityNameFoundReturnTrue(){
            Assert.False(true);
        }
    }
}
