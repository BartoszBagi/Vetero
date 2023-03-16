using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetero.Domain.Entities.Rapid.RealTime;

namespace Vetero.Domain.Entities.Rapid.ForecastItems
{
    public class ForecastWeather
    {
        public Location location { get; set; }
        public Current current { get; set; }
        public Forecast forecast { get; set; }
    }
}
