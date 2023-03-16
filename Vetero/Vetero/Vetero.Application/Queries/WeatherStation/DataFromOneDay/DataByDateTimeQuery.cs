using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetero.Application.Queries.WeatherStation.DataFromOneDay
{
    public class DataByDateTimeQuery : IRequest<List<WeatherStationDataVm>>
    {
        public DateTime DateOfData { get; set; }
    }
}


