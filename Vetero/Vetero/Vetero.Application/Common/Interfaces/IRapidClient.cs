using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetero.Application.Common.Interfaces
{
    public interface IRapidClient
    {
        Task<string> GetRealTimeWeatherAsync(string placeOrGeoOrPostCode, CancellationToken cancellationToken);
    }
}
