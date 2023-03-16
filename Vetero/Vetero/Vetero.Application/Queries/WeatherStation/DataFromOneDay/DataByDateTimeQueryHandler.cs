using log4net;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vetero.Application.Common.Interfaces;

namespace Vetero.Application.Queries.WeatherStation.DataFromOneDay
{
    public class DataByDateTimeQueryHandler : IRequestHandler<DataByDateTimeQuery, List<WeatherStationDataVm>>
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IVeteroDbContext _context;

        public DataByDateTimeQueryHandler(IVeteroDbContext context)
        {
            _context = context;
        }
        public async Task<List<WeatherStationDataVm>> Handle(DataByDateTimeQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = new List<WeatherStationDataVm>();
                var dataByDateTime = await _context.WeatherStationData.Where(d => d.DataDate.Date == request.DateOfData.Date).ToListAsync();
                if (dataByDateTime.Count > 0)
                {
                    foreach (var dataItem in dataByDateTime)
                    {
                        var dataToAdd = new WeatherStationDataVm();
                        dataToAdd = dataToAdd.MapWeatherDataToVm(dataItem);
                        result.Add(dataToAdd);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.Error($"Wystąpił błąd przy pobieraniu danych z danego dnia. {ex.Message}");
                throw ex;
            }
        }
    }
}
