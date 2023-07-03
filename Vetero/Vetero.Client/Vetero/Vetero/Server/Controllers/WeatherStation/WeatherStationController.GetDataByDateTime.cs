using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Queries.WeatherStation.OneDayData;

namespace Vetero.Server.Controllers.WeatherStation
{
    public partial class WeatherStationController
    {
        [HttpGet]
        [Route("data-by-datetime/{date}")]
        public async Task<IActionResult> GetDataByDateTimeAsync([FromRoute] string date)
        {
            try
            {
                var result = await Mediator.Send(new DataByDateTimeQuery() { Date = date });
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
