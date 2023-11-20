using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Vetero.Application.Common.Helpers;
using Vetero.Application.Common.Interfaces;
using Vetero.Application.Exceptions;
using Vetero.Domain.Entities.Api;
using Vetero.Shared.Dto.Account;

namespace Vetero.Application.Commands.Account.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponseDto>
    {
        private readonly IVeteroDbContext _context;
        private readonly IPasswordHasher<ApiUser> _passwordHasher;
        private readonly AuthenticationSettings _authenticationSettings;

        public LoginCommandHandler(IVeteroDbContext dbContext, IPasswordHasher<ApiUser> passwordHasher, IOptions<AuthenticationSettings> options)
        {
            _context = dbContext;
            _passwordHasher = passwordHasher;
            _authenticationSettings = options.Value;
        }
        public async Task<LoginResponseDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Email == request.Email);

            if (user is null)
            {
                throw new BadRequestException("Invalid username or password");
            }

            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);
            if (result == PasswordVerificationResult.Failed)
            {
                throw new BadRequestException("Invalid username or password");
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
                new Claim(ClaimTypes.Role, $"{user.Role.Name}"),
                new Claim("DateOfBirth", user.DateOfBirth != null ? user.DateOfBirth.Value.ToString("yyyy-MM-dd") : "null")
            };

            if (!string.IsNullOrEmpty(user.City))
            {
                claims.Add(
                    new Claim("City", user.City)
                );
            }
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);

            var token = new JwtSecurityToken(_authenticationSettings.JwtIssuer,
                _authenticationSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();
            var authResponse = new LoginResponseDto { Token = tokenHandler.WriteToken(token) };

            return authResponse;
        }
    }
}
