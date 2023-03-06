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
                new WeatherStationData() {Id = 1, DataDate = DateTime.Now, Temperature = 36.6},
                new WeatherStationData() { Id = 2, DataDate = DateTime.Today.AddDays(-1), Temperature = 38.6 }
                );

        }
    }
}
