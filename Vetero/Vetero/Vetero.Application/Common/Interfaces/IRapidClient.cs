using Vetero.Application.External.Queries;

namespace Vetero.Application.Common.Interfaces
{
    public interface IRapidClient
    {
        Task<string> GetRealTimeWeatherAsync(string placeOrGeoOrPostCode, CancellationToken cancellationToken);
        Task<string> GetForecastWeatherAsync(ForecastQuery query, CancellationToken cancellationToken);
    }
}
