using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Vetero.Domain.Entities.Api;
using FluentValidation;
using Vetero.Application.Commands.Account.Register;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Vetero.Application.Common.Helpers;
using Microsoft.Extensions.Configuration;

namespace Vetero.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IPasswordHasher<ApiUser>, PasswordHasher<ApiUser>>();
            services.AddScoped<IValidator<RegisterUserCommand>, RegisterUserCommandValidator>();

            var authenticationSettings = new AuthenticationSettings();
            configuration.GetSection("Authentication").Bind(authenticationSettings);

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = "Bearer";
                option.DefaultScheme = "Bearer";
                option.DefaultChallengeScheme = "Bearer";
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = authenticationSettings.JwtIssuer,
                    ValidAudience = authenticationSettings.JwtIssuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSettings.JwtKey)),
                };
            });
            return services;
        }
    }
}
