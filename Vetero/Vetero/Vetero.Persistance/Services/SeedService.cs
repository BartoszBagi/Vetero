using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Persistance.Services
{
    public static class SeedService
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<WeatherStationData>().HasData(
                new WeatherStationData()
                {
                    Id = 1,
                    DataDate = DateTime.Now,
                    Temperature = 36.6,
                    Sunrise = 7.00,
                    Sunset = 19.00,
                    Humidity = 20,
                    Wind_Kph = 30,
                    Wind_Dir = "East",
                    Pressure = 34.82,
                    TotalPrecip_mm = 0,
                    TotalPrecip_in = 0,
                    Uv = 100
                },
                new WeatherStationData() { 
                    Id = 2, 
                    DataDate = DateTime.Today.AddDays(-1), 
                    Temperature = 38.6,
                    Sunrise = 7.01,
                    Sunset = 19.01,
                    Humidity = 22,
                    Wind_Kph = 33,
                    Wind_Dir = "East",
                    Pressure = 34.82,
                    TotalPrecip_mm = 1,
                    TotalPrecip_in = 2,
                    Uv = 120
                }
                ) ;

        }
    }
}
