using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetero.Application.Common.Interfaces;
using Vetero.Domain.Entities.Rapid.ForecastItems;

namespace Vetero.Application.Queries.Rapid.Forecast
{
    public class ForecastWeatherQueryHandler : IRequestHandler<ForecastWeatherQuery, ForecastWeather>
    {
        private readonly IRapidClient _client;

        public ForecastWeatherQueryHandler(IRapidClient client)
        {
            _client = client;
        }
        public Task<ForecastWeather> Handle(ForecastWeatherQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
