using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Shared.ViewModels.WeatherStations
{
    public class CurrentDataVm
    {
        public DateTime Date { get; set; }
        public double Temperature { get; set; }

        public CurrentDataVm()
        {
            
        }

        public CurrentDataVm(WeatherStationData data)
        {
            Date = data.DataDate;
            Temperature = data.Temperature;
        }
    }
}
