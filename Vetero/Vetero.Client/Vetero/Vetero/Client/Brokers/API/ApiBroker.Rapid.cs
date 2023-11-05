using Vetero.Shared.Commands.Rapid;
using Vetero.Shared.ViewModels.Rapid.ForecastItems;
using Vetero.Shared.ViewModels.Rapid.RealTime;
using Vetero.Shared.ViewModels.Rapid.TestedData;

namespace Vetero.Client.Brokers.API
{
    public partial class ApiBroker
    {
        private const string RapidRelativeUrl = "api/rapid";
        public async Task<RealTimeWeather> GetRealTimeWeatherAsync(string location) =>
            await this.GetAsync<RealTimeWeather>($"{RapidRelativeUrl}/real-time-weather/{location}");

        public async Task<ForecastWeather> GetForecastWeatherAsync(string location, string? date = null, int? days = null, string? lang = null) =>
            await this.GetAsync<ForecastWeather>($"{RapidRelativeUrl}/forecast-weather/{location}?date={date}&days={days}&lang={lang}");

        public async Task SaveWeatherTestDataAsync(WeatherTestDataDto dto) =>
            await this.PostAsync($"{RapidRelativeUrl}/weather-test-data", dto);

        public async Task<List<DateTime>> GetTestedDatesAsync() =>
            await this.GetAsync<List<DateTime>>($"{RapidRelativeUrl}/tested-dates");

        public async Task<TestedDataModel> GetTestedDataAsync(string dateToCompare) =>
            await this.GetAsync<TestedDataModel>($"{RapidRelativeUrl}/tested-data/{dateToCompare}");
    }
}

