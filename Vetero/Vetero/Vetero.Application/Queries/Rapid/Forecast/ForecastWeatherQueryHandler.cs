using MediatR;
using Newtonsoft.Json;
using Vetero.Application.Common.Interfaces;
using Vetero.Application.External.Queries;
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
        public async Task<ForecastWeather> Handle(ForecastWeatherQuery request, CancellationToken cancellationToken)
        {
            var response = new ForecastWeather();

            var result = await _client.GetForecastWeatherAsync( new ForecastQuery() 
                                                 { Location = request.Location,
                                                    Date = request.Date,
                                                    Days = request.Days,
                                                    Lang = request.Lang }, cancellationToken
                                           );
            if (result != null)
                response = JsonConvert.DeserializeObject<ForecastWeather>(result);

            return response;

        }
    }
}
