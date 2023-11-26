using Mapster;
using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Commands.Account.UpdateCity;
using Vetero.Shared.Dto.Account;

namespace Vetero.Server.Controllers.Account
{
    public partial class AccountController
    {
        [HttpPut]
        [Route("city")]
        public async Task<IActionResult> UpdateCity([FromBody] UpdateCityDto dto)
        {
            try
            {
                var result = await Mediator.Send(dto.Adapt<UpdateCityCommand>());
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
