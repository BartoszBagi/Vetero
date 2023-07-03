using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vetero.Application.Common.Interfaces;

namespace Vetero.Persistance
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VeteroDbContext>(
                x => x.UseSqlServer(configuration.GetConnectionString("VeteroConnectionString"),
                x => x.MigrationsHistoryTable("__Vetero_MigrationHistory", "Vetero")));

            services.AddScoped<IVeteroDbContext, VeteroDbContext>();

            return services;
        }
    }
}
