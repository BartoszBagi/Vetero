using Vetero.Shared.ViewModels.WeatherStations;

namespace Vetero.Client.Brokers.API
{
    public partial class ApiBroker
    {
        private const string WeatherStationRelativeUrl = "api/weather-station";
        public async Task<CurrentDataVm> GetCurrentDataAsync() =>
            await this.GetAsync<CurrentDataVm>($"{WeatherStationRelativeUrl}/current-data");

        public async Task<IEnumerable<OneDayDataVm>> GetOneDayData(string date) =>
            await this.GetAsync<IEnumerable<OneDayDataVm>>($"{WeatherStationRelativeUrl}/data-by-datetime/{date}");
    }
}
