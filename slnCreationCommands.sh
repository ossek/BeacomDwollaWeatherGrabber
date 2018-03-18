dotnet new sln
dotnet new xunit --name BeacomDwollaWeatherGrabberTest
dotnet new console --name BeacomDwollaWeatherGrabberCli
dotnet sln BeacomDwollaWeatherGrabber.sln add BeacomDwollaWeatherGrabberCli/BeacomDwollaWeatherGrabberCli.csproj 
dotnet sln BeacomDwollaWeatherGrabber.sln add BeacomDwollaWeatherGrabberTest/BeacomDwollaWeatherGrabberTest.csproj 

