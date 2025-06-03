using System;
using System.Collections.Generic;
using System.Linq;
using WebAppj1.Entidades;

namespace WebAppj1.Services
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "uno-1", "dos-2", "tres-3", "cuatro-4", "cinco-5", "seis-6", "siete", "ocho", "nueve", "diez"
        };

        public IEnumerable<WeatherForecast> GetDatos()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
