using Microsoft.EntityFrameworkCore;
using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Application.Common.Interfaces
{
    public interface IVeteroDbContext
    {
        DbSet<WeatherStationData> WeatherStationData { get; set; }
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
