namespace Vetero.Shared.Queries.Rapid
{
    public class ForecastWeatherQueryParams
    {
        public string Location { get; set; }
        public int? Days { get; set; }
        public string? Lang { get; set; } // Returns 'condition:text' field in API in the desired language
        public string? Date { get; set; }
    }
}
