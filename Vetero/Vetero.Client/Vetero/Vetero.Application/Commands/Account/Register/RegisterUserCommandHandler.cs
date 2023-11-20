using MediatR;
using Microsoft.AspNetCore.Identity;
using Vetero.Application.Common.Interfaces;
using Vetero.Domain.Entities.Api;

namespace Vetero.Application.Commands.Account.Register
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand>
    {
        private readonly IVeteroDbContext _context;
        private readonly IPasswordHasher<ApiUser> _passwordHasher;
        public RegisterUserCommandHandler(IVeteroDbContext dbContext, IPasswordHasher<ApiUser> passwordHasher)
        {
            _context = dbContext;
            _passwordHasher = passwordHasher;
        }
        public async Task<Unit> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var isEmailInUse = _context.Users.Any(u => u.Email == request.Email);
            if (isEmailInUse)
                throw new Exception("Email zajęty");

            if (request.Password != request.ConfirmPassword)
                throw new Exception("Hasła nie poprawne");

            var newUser = new ApiUser()
            {
                Email = request.Email,
                DateOfBirth = request.DateOfBirth,
                City = request.City,
                RoleId = request.RoleId,
                FirstName = request.FirstName,
                LastName = request.LastName,
            };

            var hashedPassword = _passwordHasher.HashPassword(newUser, request.Password);
            newUser.PasswordHash = hashedPassword;

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync(false);

            return Unit.Value;
        }
    }
}
