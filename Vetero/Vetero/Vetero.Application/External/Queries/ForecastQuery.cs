using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vetero.Application.External.Queries
{
    public class ForecastQuery
    {
        public string Location { get; set; }
        public int? Days { get; set; }
        public string? Lang { get; set; } // Returns 'condition:text' field in API in the desired language
        public string? Date { get; set; }

    }
}
