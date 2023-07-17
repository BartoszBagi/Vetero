using Vetero.Shared.ViewModels.Rapid.RealTime;

namespace Vetero.Shared.ViewModels.Rapid.ForecastItems
{
    public class ForecastWeather
    {
        public Location location { get; set; }
        public Current current { get; set; }
        public Forecast forecast { get; set; }
    }
}
