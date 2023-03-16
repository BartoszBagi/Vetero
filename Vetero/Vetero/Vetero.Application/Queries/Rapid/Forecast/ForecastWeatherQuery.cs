using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetero.Domain.Entities.Rapid.ForecastItems;

namespace Vetero.Application.Queries.Rapid.Forecast
{
    public class ForecastWeatherQuery : IRequest<ForecastWeather>
    {
        public string Location { get; set; }
        public int? Days { get; set; }
        public string? Lang { get; set; } // Returns 'condition:text' field in API in the desired language
        public DateOnly? Date { get; set; }
    }
}
