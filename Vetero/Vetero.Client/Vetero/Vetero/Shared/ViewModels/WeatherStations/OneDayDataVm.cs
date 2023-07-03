namespace Vetero.Shared.ViewModels.WeatherStations
{
    public class OneDayDataVm
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
    }
}
