using Vetero.Shared.Commands.Rapid;
using Vetero.Shared.ViewModels.Rapid.ForecastItems;
using Vetero.Shared.ViewModels.Rapid.RealTime;
using Vetero.Shared.ViewModels.Rapid.TestedData;

namespace Vetero.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<ForecastWeather> GetForecastWeatherAsync(string location, string? date = null, int? days = null, string? lang = null);
        Task<RealTimeWeather> GetRealTimeWeatherAsync(string location);
        Task SaveWeatherTestDataAsync(WeatherTestDataDto dto);
        Task<List<DateTime>> GetTestedDatesAsync();
        Task<TestedDataModel> GetTestedDataAsync(string dateToCompare);
    }
}
