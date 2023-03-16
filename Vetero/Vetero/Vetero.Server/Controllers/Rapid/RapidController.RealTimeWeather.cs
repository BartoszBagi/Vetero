using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Queries.Rapid.RealTime;
using Vetero.Application.Queries.WeatherStation.CurrentData;

namespace Vetero.Server.Controllers.Rapid
{
    public partial class RapidController
    {
        [HttpGet]
        [Route("real-time-weather/{location}")]
        public async Task<IActionResult> GetRealTimeWeatherAsync(string location)
        {
            try
            {
                var result = await Mediator.Send(new RealTimeWeatherQuery() { Location = location });
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
