using MediatR;
using Vetero.Shared.ViewModels.Rapid.RealTime;

namespace Vetero.Application.Queries.Rapid.RealTime
{
    public class RealTimeWeatherQuery : IRequest<RealTimeWeather>
    {
        public string Location { get; set; }
    }
}
