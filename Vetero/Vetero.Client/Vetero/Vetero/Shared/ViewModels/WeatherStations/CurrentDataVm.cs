using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Shared.ViewModels.WeatherStations
{
    public class CurrentDataVm
    {
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public string WeatherImage { get; set; }
        public double WindKph { get; set; }
        public string WindDir { get; set; }
        public double TotalPrecip_in { get; set; }
        public string WeatherDescription { get; set; }

        public CurrentDataVm()
        {
            
        }

        public CurrentDataVm(WeatherStationData data)
        {
            Date = data.Date;
            Temperature = data.Temperature;
            WindKph = data.WindKph;
            WindDir = data.WindDir;
            TotalPrecip_in = data.TotalPrecip_in;
        }
    }
}
