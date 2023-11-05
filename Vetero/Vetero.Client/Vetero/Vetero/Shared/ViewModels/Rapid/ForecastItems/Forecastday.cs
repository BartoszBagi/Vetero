using Vetero.Shared.Commands.Rapid;

namespace Vetero.Shared.ViewModels.Rapid.ForecastItems
{
    public class Forecastday
    {
        public string date { get; set; }
        public int date_epoch { get; set; }
        public Day day { get; set; }
        public Astro astro { get; set; }
        public List<Hour> hour { get; set; }

        public WeatherTestDataDto ToTestData()
        {
            return new WeatherTestDataDto()
            {
                Date = DateTime.Parse(date),
                Humidity = day.avghumidity,
                Temperature = day.avgtemp_c,
                TotalPrecip_mm = day.totalprecip_mm,
                WindKph = day.maxwind_kph
            };
        }
    }
}
