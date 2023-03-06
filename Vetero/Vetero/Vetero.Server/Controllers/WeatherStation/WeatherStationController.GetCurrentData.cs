using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Queries.WeatherStation;
using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Server.Controllers.WeatherStation
{
    public partial class WeatherStationController
    {
        [HttpGet]
        [Route("currentdata")]
        public async Task<WeatherStationData> GetCurrentDataAsync(CurrentDataQuery query)
        {
            var result = await Mediator.Send(query);
            return result;
        }
    }
}
