using System;
using Xunit;
using BeacomDwollaWeatherGrabberInterfaces;
using Moq;
using BeacomDwollaWeatherGrabberOpenWeatherService;

namespace BeacomDwollaWeatherGrabberTest
{
    public class WhenGettingTemperatureReply
    {
        public WhenGettingTemperatureReply()
        {
        }

        [Fact]
        public void AndCityIsInvalidThenErrorTextReturned()
        {
            var invalidCityService = new Mock<ITemperatureService>();
            invalidCityService.Setup(m => m.CityIsValid(It.IsAny<string>())).Returns(false);
            var temperatureReplyService = new TemperatureReplyService(invalidCityService.Object);
            var reply = temperatureReplyService.GetTemperatureReply("any city");
            var expected = "Sorry, any city is not a valid city";
            Assert.Equal(expected, reply);
        }

        [Fact]
        public void AndTemperatureFoundThenTempTextReturned()
        {
            var validCityService = new Mock<ITemperatureService>();
            validCityService.Setup(m => m.CityIsValid(It.IsAny<string>())).Returns(true);
            validCityService.Setup(m => m.GetTemperatureForCity(It.IsAny<string>())).Returns(77.82);
            var temperatureReplyService = new TemperatureReplyService(validCityService.Object);
            var reply = temperatureReplyService.GetTemperatureReply("any city");
            var expected = "Temperature for any city is 77.82 degrees fahrenheit";
            Assert.Equal(expected, reply);
        }

        [Fact]
        public void AndErrorMakingApiCallThenExceptionThrown()
        {
            var validCityService = new Mock<ITemperatureService>();
            validCityService.Setup(m => m.CityIsValid(It.IsAny<string>())).Returns(true);
            validCityService.Setup(m => m.GetTemperatureForCity(It.IsAny<string>()))
              .Throws(new ArgumentException("prob"));
            var temperatureReplyService = new TemperatureReplyService(validCityService.Object);
            Exception caught = null;
            var reply = temperatureReplyService.GetTemperatureReply("any city");
            var expected = "Sorry, there was a problem getting weather data for any city";
            Assert.Equal(expected, reply);
        }
    }
}
