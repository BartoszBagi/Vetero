using Vetero.Shared.Commands.Rapid;
using Vetero.Shared.ViewModels.Rapid.ForecastItems;
using Vetero.Shared.ViewModels.Rapid.RealTime;

namespace Vetero.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<ForecastWeather> GetForecastWeatherAsync(string location, string? date = null, int? days = null, string? lang = null);
        Task<RealTimeWeather> GetRealTimeWeatherAsync(string location);
        Task SaveWeatherTestData(WeatherTestDataDto dto);
    }
}
