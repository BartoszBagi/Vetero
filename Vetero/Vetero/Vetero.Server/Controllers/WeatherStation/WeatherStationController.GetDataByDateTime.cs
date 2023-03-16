using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Queries.WeatherStation.CurrentData;
using Vetero.Application.Queries.WeatherStation.DataFromOneDay;

namespace Vetero.Server.Controllers.WeatherStation
{
    public partial class WeatherStationController
    {
        [HttpGet]
        [Route("data-by-datetime")]
        public async Task<IActionResult> GetDataByDateTimeAsync(DateTime dateOfData)
        {
            try
            {
                var result = await Mediator.Send(new DataByDateTimeQuery() { DateOfData = dateOfData });
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
