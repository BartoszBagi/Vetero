using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Application.Queries.WeatherStation
{
    public class WeatherStationDataVm
    {
        public DateTime DataDate { get; set; }
        public double Temperature { get; set; }
        public string? Message { get; set; }

        public WeatherStationDataVm MapWeatherDataToVm(WeatherStationData data)
        {
            var result = new WeatherStationDataVm()
            {
                DataDate = data.DataDate,
                Temperature = data.Temperature,                
            };

            return result;
        }
    }
}
