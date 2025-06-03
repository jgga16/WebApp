using NUnit.Framework;
using System.Linq;
using WebAppj1.Services;

namespace WebAppJ1.Tests
{
    public class TestsWeatherForecastService
    {
        WeatherForecastService forecastService;

        [SetUp]
        public void Setup()
        {
            forecastService = new WeatherForecastService();
        }

        [Test]
        public void Test1()
        {
            var datos =  forecastService.GetDatos();
            Assert.AreEqual(5, datos.Count());
            Assert.Pass();
        }
    }
}