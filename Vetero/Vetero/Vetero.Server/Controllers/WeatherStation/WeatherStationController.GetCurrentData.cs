﻿using Microsoft.AspNetCore.Mvc;
using Vetero.Application.Queries.WeatherStation.CurrentData;
using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Server.Controllers.WeatherStation
{
    public partial class WeatherStationController
    {
        [HttpGet]
        [Route("current-data")]
        public async Task<IActionResult> GetCurrentDataAsync()
        {
            try
            {
                var result = await Mediator.Send(new CurrentDataQuery());
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
