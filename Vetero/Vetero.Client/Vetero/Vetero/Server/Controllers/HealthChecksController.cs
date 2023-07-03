using Microsoft.AspNetCore.Mvc;
using Vetero.Server.Models.Error;

namespace Vetero.Server.Properties.Controllers
{
    [ApiController]
    [Route("api/hc")]
    public class HealthChecksController : ControllerBase
    {
        public HealthChecksController()
        {

        }

        [HttpGet("/hc")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetAsync()
        {

            return "Healthy";
        }
    }
}
