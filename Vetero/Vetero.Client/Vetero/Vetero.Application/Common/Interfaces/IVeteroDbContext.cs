using Microsoft.EntityFrameworkCore;
using Vetero.Domain.Entities.Api;
using Vetero.Domain.Entities.Rapid;
using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Application.Common.Interfaces
{
    public interface IVeteroDbContext
    {
        DbSet<WeatherStationData> WeatherStationData { get; set; }
        DbSet<WeatherTestData> WeatherTestData { get; set; }
        DbSet<ApiUser> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
