using Vetero.Shared.Dto.Account;

namespace Vetero.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<LoginResponseDto> LoginAsync(LoginUserDto userDto);
        Task RegisterAsync(RegisterUserDto user);
    }
}
