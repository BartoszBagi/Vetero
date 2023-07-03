using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Application.Queries.WeatherStation.OneDayData
{
    public class OneDayDataDto
    {
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public double Sunrise { get; set; }
        public double Sunset { get; set; }
        public double Humidity { get; set; }
        public double WindKph { get; set; }
        public string WindDir { get; set; }
        public double Pressure { get; set; }
        public double TotalPrecip_mm { get; set; }
        public double TotalPrecip_in { get; set; }
        public double Uv { get; set; }

        public OneDayDataDto(WeatherStationData data)
        {
            Date = data.DataDate; 
            Temperature = data.Temperature;
            Sunrise = data.Sunrise;
            Sunset = data.Sunset;
            Humidity = data.Humidity;
            WindKph = data.WindKph;
            WindDir = data.WindDir;
            Pressure = data.Pressure;
            TotalPrecip_mm = data.TotalPrecip_mm;
            TotalPrecip_in = data.TotalPrecip_in;
            Uv = data.Uv;
        }
    }
}
