using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetero.Application.Common.Interfaces;
using Vetero.Domain.Entities.Rapid.RealTime;

namespace Vetero.Application.Queries.Rapid.RealTime
{
    public class RealTimeWeatherQueryHandler : IRequestHandler<RealTimeWeatherQuery, RealTimeWeather>
    {
        private readonly IRapidClient _client;

        public RealTimeWeatherQueryHandler(IRapidClient client)
        {
            _client = client;
        }

        public async Task<RealTimeWeather> Handle(RealTimeWeatherQuery request, CancellationToken cancellationToken)
        {
            var response = new RealTimeWeather();
            var result = await _client.GetRealTimeWeatherAsync(request.Location, cancellationToken);

            if (result != null)
                response = JsonConvert.DeserializeObject<RealTimeWeather>(result);

            return response;
        }
    }
}
