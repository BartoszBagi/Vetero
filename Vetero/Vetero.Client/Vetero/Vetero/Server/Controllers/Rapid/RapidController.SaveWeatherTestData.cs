using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Commands.RapidApi.SaveWeatherTestData;
using Vetero.Application.Queries.Rapid.RealTime;
using Vetero.Shared.Commands.Rapid;

namespace Vetero.Server.Controllers.Rapid
{
    public partial class RapidController
    {
        [HttpPost]
        [Route("weather-test-data")]
        public async Task<IActionResult> SaveWeatherTestDataAsync([FromBody] WeatherTestDataDto dto)
        {
            try
            {
                await Mediator.Send(new WeatherTestDataCommand(dto));
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
