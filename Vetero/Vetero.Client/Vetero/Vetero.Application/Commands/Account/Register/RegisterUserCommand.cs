using MediatR;

namespace Vetero.Application.Commands.Account.Register
{
    public class RegisterUserCommand : IRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string City { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int RoleId { get; set; } = 1;
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
