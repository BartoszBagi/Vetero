using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Queries.Rapid.Forecast;
using Vetero.Application.Queries.Rapid.RealTime;

namespace Vetero.Server.Controllers.Rapid
{
    public partial class RapidController
    {
        [HttpGet]
        [Route("forecast-weather")]
        public async Task<IActionResult> GetForecastWeatherAsync([FromQuery] ForecastWeatherQuery query)
        {
            try
            {
                var result = await Mediator.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
