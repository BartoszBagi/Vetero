using MediatR;
using System.ComponentModel.DataAnnotations;
using Vetero.Domain.Entities.Rapid.ForecastItems;

namespace Vetero.Application.Queries.Rapid.Forecast
{
    public class ForecastWeatherQuery : IRequest<ForecastWeather>
    {
        [Required]
        public string Location { get; set; }
        public int? Days { get; set; }
        public string? Lang { get; set; } // Returns 'condition:text' field in API in the desired language
        public string? Date { get; set; }
    }
}
