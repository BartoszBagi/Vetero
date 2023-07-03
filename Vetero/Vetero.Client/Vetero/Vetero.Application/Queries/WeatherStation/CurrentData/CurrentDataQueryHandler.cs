using log4net;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Vetero.Application.Common.Interfaces;
using Vetero.Shared.ViewModels.WeatherStations;

namespace Vetero.Application.Queries.WeatherStation.CurrentData
{
    public class CurrentDataQueryHandler : IRequestHandler<CurrentDataQuery, CurrentDataVm>
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IVeteroDbContext _context;
        private const string NoWeatherDataError = "W bazie danych nie znaleziono rekordu spełniajęcgo kryteria.";
        private const string CurrentDataError = "Wystąpił błąd przy pobieraniu aktualnych danych ze stacji pogodowej.";
        public CurrentDataQueryHandler(IVeteroDbContext context)
        {
            _context = context;
        }
        public async Task<CurrentDataVm> Handle(CurrentDataQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _context.WeatherStationData.OrderBy(x => x).LastOrDefaultAsync();
                if (result != null)
                    return new CurrentDataVm(result);
                else
                    throw new FileNotFoundException(NoWeatherDataError);
            }
            catch (Exception ex)
            {
                _logger.Error(CurrentDataError);
                throw new Exception(ex.Message);
            }

        }
    }
}
