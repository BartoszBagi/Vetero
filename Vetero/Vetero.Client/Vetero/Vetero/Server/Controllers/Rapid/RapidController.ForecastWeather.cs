using Microsoft.AspNetCore.Mvc;
using Radzen.Blazor.Rendering;
using Vetero.Application.Queries.Rapid.Forecast;
using Vetero.Shared.Queries.Rapid;

namespace Vetero.Server.Controllers.Rapid
{
    public partial class RapidController
    {
        [HttpGet]
        [Route("forecast-weather/{location}")]
        public async Task<IActionResult> GetForecastWeatherAsync(string location, string? date, int? days, string? lang)
        {
            try
            {
                var result = await Mediator.Send(new ForecastWeatherQuery()
                {
                    Location = location,
                    Date = date,
                    Days = days,
                    Lang = lang
                });
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
