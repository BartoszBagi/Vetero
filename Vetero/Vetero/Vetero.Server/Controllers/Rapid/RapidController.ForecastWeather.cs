using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Queries.Rapid.Forecast;
using Vetero.Application.Queries.Rapid.RealTime;

namespace Vetero.Server.Controllers.Rapid
{
    public partial class RapidController
    {
        [HttpGet]
        [Route("real-time-weather/{location}/{days?}/{lang?}/{date}")]
        public async Task<IActionResult> GetForecastWeatherAsync(string location, int? days = null, string? lang = null, DateOnly? date = null )
        {
            try
            {
                var result = await Mediator.Send(new ForecastWeatherQuery() { Location = location, 
                                                                        Days = days,
                                                                        Lang = lang,
                                                                        Date = date });
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
