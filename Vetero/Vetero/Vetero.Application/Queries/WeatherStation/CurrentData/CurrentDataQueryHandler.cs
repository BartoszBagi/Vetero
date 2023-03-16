using log4net.Config;
using log4net;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Vetero.Application.Common.Interfaces;
using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Application.Queries.WeatherStation.CurrentData
{
    public class CurrentDataQueryHandler : IRequestHandler<CurrentDataQuery, WeatherStationDataVm>
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IVeteroDbContext _context;
        private const string NoWeatherDataError = "W bazie danych nie znaleziono rekordu spełniajęcgo kryteria.";
        
        public CurrentDataQueryHandler(IVeteroDbContext context)
        {
            _context = context;
        }
        public async Task<WeatherStationDataVm> Handle(CurrentDataQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var response = new WeatherStationDataVm();
                var result = await _context.WeatherStationData.OrderBy(x => x).LastOrDefaultAsync();
                if (response != null)
                {
                    response.DataDate = result.DataDate;
                    response.Temperature = result.Temperature;
                }
                else
                    response.Message = NoWeatherDataError;

                return response;
            }
            catch (Exception ex)
            {
                _logger.Error($"Wystąpił błąd przy pobieraniu aktualnych danych ze stacji pogodowej.");
                throw;
            }
            
        }
    }
}
