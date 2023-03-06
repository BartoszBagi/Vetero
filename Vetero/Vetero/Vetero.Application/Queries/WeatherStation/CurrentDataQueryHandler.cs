using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Application.Queries.WeatherStation
{
    public class CurrentDataQueryHandler : IRequestHandler<CurrentDataQuery, WeatherStationData>
    {
        public Task<WeatherStationData> Handle(CurrentDataQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
