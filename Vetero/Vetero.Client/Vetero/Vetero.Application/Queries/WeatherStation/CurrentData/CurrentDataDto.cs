using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Application.Queries.WeatherStation.CurrentData
{
    public class CurrentDataDto
    {
        public DateTime Date { get; set; }
        public double Temperature { get; set; }

        public CurrentDataDto MapToVm(WeatherStationData data)
        {
            var result = new CurrentDataDto()
            {
                Date = data.DataDate,
                Temperature = data.Temperature,
            };

            return result;
        }
    }
}
