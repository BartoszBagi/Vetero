﻿using System.Text.Json;
using Vetero.Shared.Dto.Account;

namespace Vetero.Client.Brokers.API
{
    public partial class ApiBroker
    {
        private const string AuthRelativeUrl = "api/account";
        public async Task<LoginResponseDto> LoginAsync(LoginUserDto userDto)
        {
            var response = await this.PostAsync<LoginUserDto>(AuthRelativeUrl + "/login", userDto);
            var str = await response.Content.ReadAsStringAsync();

            var auth = JsonSerializer.Deserialize<LoginResponseDto>(str, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return auth;
        }

        public async Task<bool> UpdateCityAsync(UpdateCityDto cityDto)
        {
            var response = await this.PutAsync<UpdateCityDto>(AuthRelativeUrl + "/city", cityDto);
            var str = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<bool>(str, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return result;
        }

        public async Task RegisterAsync(RegisterUserDto user) =>
            await this.PostAsync(AuthRelativeUrl + "/register", user);
    }
}