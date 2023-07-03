using MediatR;
using Vetero.Shared.ViewModels.WeatherStations;

namespace Vetero.Application.Queries.WeatherStation.CurrentData
{
    public class CurrentDataQuery : IRequest<CurrentDataVm>
    {
    }
}
