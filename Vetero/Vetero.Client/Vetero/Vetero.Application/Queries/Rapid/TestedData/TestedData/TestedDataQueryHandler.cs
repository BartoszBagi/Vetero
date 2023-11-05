using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Vetero.Application.Common.Interfaces;
using Vetero.Application.Helpers;
using Vetero.Shared.Commands.Rapid;
using Vetero.Shared.Dto;
using Vetero.Shared.Dto.WeatherStation;
using Vetero.Shared.ViewModels.Rapid.TestedData;

namespace Vetero.Application.Queries.Rapid.TestedData.TestedData
{
    public class TestedDataQueryHandler : IRequestHandler<TestedDataQuery, TestedDataModel>
    {
        private readonly IVeteroDbContext _dbContext;

        public TestedDataQueryHandler(IVeteroDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TestedDataModel> Handle(TestedDataQuery request, CancellationToken cancellationToken)
        {
            var result = new TestedDataModel();
            var dateToCompare = DateTime.Parse(request.DateToCompare);
            var stationData = await (_dbContext.WeatherStationData.Where(d => d.Date.Date == dateToCompare.Date)).ToListAsync();
            var dataToBeTested = await (_dbContext.WeatherTestData.Where(d => d.Date.Date == dateToCompare.Date)).FirstOrDefaultAsync();

            if (stationData.Any() && dataToBeTested != null)
            {
                var divider = stationData.Count();
                var dataToCompare = new WeatherStationCompareDataDto()
                {
                    Temperature = stationData.Sum(x => x.Temperature) / divider,
                    TotalPrecip_mm = stationData.Sum(x => x.TotalPrecip_mm) / divider,
                    Humidity = stationData.Sum(x => x.Humidity) / divider,
                    WindKph = stationData.Sum(x => x.WindKph) / divider
                };

                var compareResult = new CompareWeatherResultDto()
                {
                    Temperature = Math.Round(MathHelper.CalculatePercents(dataToBeTested.Temperature, dataToCompare.Temperature), 2),
                    Humidity = Math.Round(MathHelper.CalculatePercents(dataToBeTested.Humidity, dataToCompare.Humidity), 2),
                    TotalPrecip_mm = Math.Round(MathHelper.CalculatePercents(dataToBeTested.TotalPrecip_mm, dataToCompare.TotalPrecip_mm), 2),
                    WindKph = Math.Round(MathHelper.CalculatePercents(dataToBeTested.WindKph, dataToCompare.WindKph), 2),
                };

                var weatherTestDataDto = dataToBeTested.Adapt<WeatherTestDataDto>();

                result.WeatherTestData = weatherTestDataDto;
                result.StationCompareData = dataToCompare;
                result.CompareResults = compareResult;              
            }
            return result;
        }
    }
}
