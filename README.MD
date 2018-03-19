[![Build Status](https://travis-ci.org/ossek/BeacomDwollaWeatherGrabber.svg?branch=master)](https://travis-ci.org/ossek/BeacomDwollaWeatherGrabber)

#### .Net Core project to grab temp data given a city name, to show to Dwolla folks.
Runnable with run.sh or the usual dotnet build commands on a platform that has dotnet installed.

##### Possible Next steps
 - Use a real DI framework
 - use cli / console interaction framework
 - add a UI
 - consider other languages that Dwolla uses more frequently day to day (scala, python)
 - find a weather api that supports swagger codegen
 - handle other non-OK / 200 status codes as a normal case via some response object
 - wrap part or all of HttpClient in an interface so mocking can be done at the level of http responses
 - explore other ways of specifying the return deserialization type rather than anonymous type inference from example
 - look into other ways of checking city validity such as the list of codes on the OpenWeather api site
 - provide Self-contained executable / exe artifacts or others
 - some sort of secret management or at least unhardcode api key and move to .config file

