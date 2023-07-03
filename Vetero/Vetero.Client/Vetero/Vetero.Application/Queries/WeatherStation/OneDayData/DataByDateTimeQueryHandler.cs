using MediatR;
using Microsoft.EntityFrameworkCore;
using Vetero.Application.Common.Interfaces;

namespace Vetero.Application.Queries.WeatherStation.OneDayData
{
    public class DataByDateTimeQueryHandler : IRequestHandler<DataByDateTimeQuery, IEnumerable<OneDayDataDto>>
    {
        private readonly IVeteroDbContext _context;

        public DataByDateTimeQueryHandler(IVeteroDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<OneDayDataDto>> Handle(DataByDateTimeQuery request, CancellationToken cancellationToken)
        {
            var result = new List<OneDayDataDto>();
            DateTime date = DateTime.Parse(request.Date);
            var dataByDateTime = await _context.WeatherStationData.Where(d => d.DataDate.Date == date).ToListAsync();
            if (dataByDateTime.Any())
            {
                foreach (var dataItem in dataByDateTime)
                {
                    result.Add(new OneDayDataDto(dataItem));
                }
            }

            return result.OrderBy(x => x.Date);
        }
    }
}
