using Vetero.Shared.ViewModels.WeatherStations;

namespace Vetero.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<CurrentDataVm> GetCurrentDataAsync();
        Task<IEnumerable<OneDayDataVm>> GetOneDayData(string date);
    }
}
