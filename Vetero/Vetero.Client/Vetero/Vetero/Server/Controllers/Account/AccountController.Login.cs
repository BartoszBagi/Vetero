using Mapster;
using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Commands.Account.Login;
using Vetero.Shared.Dto.Account;

namespace Vetero.Server.Controllers.Account
{
    public partial class AccountController
    {
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto dto)
        {
            try
            {
                var token = await Mediator.Send(dto.Adapt<LoginCommand>());
                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
