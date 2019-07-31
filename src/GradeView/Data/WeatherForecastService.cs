using System;
using System.Linq;
using System.Threading.Tasks;

namespace GradeView.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            WeatherForecast[] WeatherArray = new WeatherForecast[7];
            for (int i = 0; i < 7; i++)
            {
                DateTime Date = startDate.AddDays(i);
                int TemperatureC = rng.Next(-20, 50);
                string Summary = Summaries[(TemperatureC + 20) / 7];
                WeatherArray[i] = new WeatherForecast { Date = Date, TemperatureC = TemperatureC, Summary = Summary };
            }
            return Task.FromResult(WeatherArray);
        }
    }
}
