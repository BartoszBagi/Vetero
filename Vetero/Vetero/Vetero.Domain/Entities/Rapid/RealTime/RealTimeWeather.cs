﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetero.Domain.Entities.Rapid.RealTime
{
    public class RealTimeWeather
    {
        public Location location { get; set; }
        public Current current { get; set; }
    }
}
