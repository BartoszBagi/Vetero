namespace Vetero.Domain.Entities.Rapid
{
    public class WeatherTestData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double WindKph { get; set; }
        public double TotalPrecip_mm { get; set; }
    }
}
