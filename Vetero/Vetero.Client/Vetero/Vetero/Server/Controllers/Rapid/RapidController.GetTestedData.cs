using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Queries.Rapid.TestedData.TestedData;

namespace Vetero.Server.Controllers.Rapid
{
    public partial class RapidController
    {
        [HttpGet]
        [Route("tested-data/{dateToCompare}")]
        public async Task<IActionResult> GetTestedDataAsync(string dateToCompare)
        {
            try
            {
                var result = await Mediator.Send(new TestedDataQuery() { DateToCompare = dateToCompare });
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
