using MediatR;
using Vetero.Application.Common.Interfaces;

namespace Vetero.Application.Commands.Account.UpdateCity
{
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, bool>
    {
        private readonly IVeteroDbContext _dbContext;

        public UpdateCityCommandHandler(IVeteroDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == request.UserId);
            if (user == null)
                throw new ArgumentException("There is no user in database with provided id.");

            if (string.IsNullOrEmpty(user.City))
                throw new ArgumentException("City must contains any character.");

            user.City = request.City;

            await _dbContext.SaveChangesAsync(true);

            return true;
        }
    }
}
