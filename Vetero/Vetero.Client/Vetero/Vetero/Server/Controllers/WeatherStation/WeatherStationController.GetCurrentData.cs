using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Queries.WeatherStation.CurrentData;

namespace Vetero.Server.Controllers.WeatherStation
{
    public partial class WeatherStationController
    {
        [HttpGet]
        [Route("current-data")]
        public async Task<IActionResult> GetCurrentDataAsync()
        {
            try
            {
                var response = await Mediator.Send(new CurrentDataQuery());
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
