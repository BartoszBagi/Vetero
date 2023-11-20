using MediatR;
using Vetero.Shared.Dto.Account;

namespace Vetero.Application.Commands.Account.Login
{
    public class LoginCommand : IRequest<LoginResponseDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
