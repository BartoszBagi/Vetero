using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Queries.Rapid.RealTime;
using Vetero.Application.Queries.Rapid.TestedData.TestedDates;

namespace Vetero.Server.Controllers.Rapid
{
    public partial class RapidController
    {
        [HttpGet]
        [Route("tested-dates")]
        public async Task<IActionResult> GetTestedDatesAsync()
        {
            try
            {
                var result = await Mediator.Send(new TestedDatesQuery());
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
