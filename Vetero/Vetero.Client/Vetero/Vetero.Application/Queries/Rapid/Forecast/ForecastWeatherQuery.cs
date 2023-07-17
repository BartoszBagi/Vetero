using MediatR;
using System.ComponentModel.DataAnnotations;
using Vetero.Shared.ViewModels.Rapid.ForecastItems;

namespace Vetero.Application.Queries.Rapid.Forecast
{
    public class ForecastWeatherQuery : IRequest<ForecastWeather>
    {
        [Required]
        public string Location { get; set; }
        public int? Days { get; set; }
        public string? Lang { get; set; }
        public string? Date { get; set; }
    }
}
