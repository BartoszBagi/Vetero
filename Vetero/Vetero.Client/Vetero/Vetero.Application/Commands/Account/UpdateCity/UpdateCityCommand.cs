using MediatR;

namespace Vetero.Application.Commands.Account.UpdateCity
{
    public class UpdateCityCommand : IRequest<bool>
    {
        public int UserId { get; set; }
        public string City { get; set; }
    }
}
