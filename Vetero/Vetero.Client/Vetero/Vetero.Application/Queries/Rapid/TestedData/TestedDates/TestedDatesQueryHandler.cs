using MediatR;
using Microsoft.EntityFrameworkCore;
using Vetero.Application.Common.Interfaces;

namespace Vetero.Application.Queries.Rapid.TestedData.TestedDates
{
    public class TestedDatesQueryHandler : IRequestHandler<TestedDatesQuery, List<DateTime>>
    {
        private readonly IVeteroDbContext _dbContext;

        public TestedDatesQueryHandler(IVeteroDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<List<DateTime>> Handle(TestedDatesQuery request, CancellationToken cancellationToken)
        {
            var testedDates = _dbContext.WeatherTestData.Where(x => x.Date < DateTime.Now).Select(x => x.Date).ToListAsync();
             
            return testedDates;
        }
    }
}
