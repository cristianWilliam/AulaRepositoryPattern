using AulaRepositoryPattern.Core.Models;
using AulaRepositoryPattern.Data.Context;
using AulaRepositoryPattern.Data.Repositories;
using AulaRepositoryPattern.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AulaRepositoryPattern.Data.Extensions
{
    public static class DataExtensions
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ICarroRepository, CarroRepository>();
            return services;
        }
    }
}