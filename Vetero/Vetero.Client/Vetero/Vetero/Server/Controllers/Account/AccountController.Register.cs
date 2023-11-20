using Mapster;
using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Commands.Account.Register;
using Vetero.Shared.Dto.Account;

namespace Vetero.Server.Controllers.Account
{
    public partial class AccountController
    {
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterUserDto dto)
        {
            try
            {
                await Mediator.Send(dto.Adapt<RegisterUserCommand>());
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }    
    }
}
