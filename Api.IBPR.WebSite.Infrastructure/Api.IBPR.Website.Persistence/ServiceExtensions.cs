using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Infrastructure.Persistence.Context;
using Api.IBPR.Website.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.IBPR.Website.Infrastructure.Persistence
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("OracleConnection");
            services.AddDbContext<OracleDbContext>(opt => opt.UseOracle(connectionString));
            //services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ArticleRepository, ArticleRepository>();

            return services;
        }
    }
}