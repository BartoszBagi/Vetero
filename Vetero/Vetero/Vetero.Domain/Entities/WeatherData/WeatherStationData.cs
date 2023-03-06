using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetero.Domain.Entities.WeatherData
{
    public class WeatherStationData
    {
        public int Id { get; set; }
        public DateTime DataDate { get; set; }
        public double Temperature { get; set; }

    }
}
