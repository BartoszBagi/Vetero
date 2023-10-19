using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Vetero.Application.Common.Interfaces;
using Vetero.Domain.Entities.Rapid;

namespace Vetero.Application.Commands.RapidApi.SaveWeatherTestData
{
    public class WeatherTestDataCommandHandler : IRequestHandler<WeatherTestDataCommand>
    {
        private readonly IVeteroDbContext _veteroDbContext;

        public WeatherTestDataCommandHandler(IVeteroDbContext veteroDbContext)
        {
            _veteroDbContext = veteroDbContext;
        }
        public async Task<Unit> Handle(WeatherTestDataCommand request, CancellationToken cancellationToken)
        {
            var isExists = await _veteroDbContext.WeatherTestData.Where(x => x.Date == request.Date).AnyAsync();

            if(!isExists)
                await _veteroDbContext.WeatherTestData.AddAsync(request.Adapt<WeatherTestData>());

            await _veteroDbContext.SaveChangesAsync(true);

            return Unit.Value;
        }
    }
}
