using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using Vetero.Shared.Dto.Account;

namespace Vetero.Client.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
        Task<AuthenticationState> GetAuthenticationStateAsync();
        Task<IEnumerable<Claim>> GetAuthenticatedUserClaims();
    }
}
