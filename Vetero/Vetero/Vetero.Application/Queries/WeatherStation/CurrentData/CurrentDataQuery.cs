using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Application.Queries.WeatherStation.CurrentData
{
    public class CurrentDataQuery : IRequest<WeatherStationDataVm>
    {
    }
}
