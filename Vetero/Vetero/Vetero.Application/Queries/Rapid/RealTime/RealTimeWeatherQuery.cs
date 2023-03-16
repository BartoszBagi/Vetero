using MediatR;
using Vetero.Domain.Entities.Rapid.RealTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetero.Application.Queries.Rapid.RealTime
{
    public class RealTimeWeatherQuery : IRequest<RealTimeWeather>
    {
        public string Location{ get; set; }
    }
}
