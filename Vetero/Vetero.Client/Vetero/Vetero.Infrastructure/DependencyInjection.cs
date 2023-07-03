using Microsoft.Extensions.DependencyInjection;
using Vetero.Application.Common.Interfaces;
using Vetero.Infrastructure.ExternalApi.Rapid;

namespace Vetero.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddHttpClient("RapidClient", options =>
            {
                options.BaseAddress = new Uri("https://weatherapi-com.p.rapidapi.com");
                options.Timeout = new TimeSpan(0, 0, 10);
                options.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }).ConfigurePrimaryHttpMessageHandler(sp => new HttpClientHandler());

            services.AddScoped<IRapidClient, RapidClient>();

            return services;
        }
    }
}
