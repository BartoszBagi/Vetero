namespace Vetero.Shared.ViewModels.WeatherStations
{
    public class AvgDayDataVm
    {
        public string Date { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double WindKph { get; set; }
        public double Pressure { get; set; }
        public double TotalPrecip_in { get; set; }
        public string WindDir { get; set; }
        public double Uv { get; set; }

        public AvgDayDataVm(IEnumerable<OneDayDataVm> data)
        {
            WindDir = data.Select(x => x.WindDir).LastOrDefault();
            Date = data.FirstOrDefault().Date.ToString("dd-MM-yyyy");
            Temperature = data.Sum(x => x.Temperature) / data.Count();
            Humidity = data.Sum(x => x.Humidity) / data.Count();
            WindKph = data.Sum(x => x.WindKph) / data.Count();
            Pressure = data.Sum(x => x.Pressure) / data.Count();
            TotalPrecip_in = data.LastOrDefault().TotalPrecip_in / int.Parse(data.LastOrDefault().Date.ToString("HH"));
            Uv = data.Sum(x => x.Uv) / data.Count();
        }
    }
}
