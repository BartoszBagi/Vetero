using MediatR;
using Vetero.Shared.Commands.Rapid;

namespace Vetero.Application.Commands.RapidApi.SaveWeatherTestData
{
    public class WeatherTestDataCommand : IRequest
    {
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double WindKph { get; set; }
        public double TotalPrecip_mm { get; set; }

        public WeatherTestDataCommand(WeatherTestDataDto dto)
        {
            Temperature = dto.Temperature;
            Humidity = dto.Humidity;
            WindKph = dto.WindKph;
            TotalPrecip_mm = dto.TotalPrecip_mm;
            Date = dto.Date;
        }
    }
}
