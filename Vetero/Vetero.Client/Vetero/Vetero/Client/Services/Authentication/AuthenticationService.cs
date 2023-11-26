using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using Vetero.Client.Providers;
using Vetero.Shared.Dto.Account;

namespace Vetero.Client.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IApiBroker broker;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AuthenticationService(IApiBroker broker, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            this.broker = broker;
            this.localStorage = localStorage;
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> AuthenticateAsync(LoginUserDto loginModel)
        {
            var response = await broker.LoginAsync(loginModel);

            await localStorage.SetItemAsync("accessToken", response.Token);

            await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedIn();

            return true;
        }
        public async Task Logout()
        {
            await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedOut();

        }

        public async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return await ((ApiAuthenticationStateProvider)authenticationStateProvider).GetAuthenticationStateAsync();
        }
        public async Task<IEnumerable<Claim>> GetAuthenticatedUserClaims()
        {
            var authenticationState = await GetAuthenticationStateAsync();
            var identity = authenticationState.User.Identities.FirstOrDefault();
            var claims = identity.Claims;

            return claims;
        }

    }
}
