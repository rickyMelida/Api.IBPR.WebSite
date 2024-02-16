using Api.IBPR.Website.Application.Repositories;
using Api.IBPR.Website.Persistence.Context;
using Api.IBPR.Website.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.IBPR.Website.Persistence
{
    public static class ServiceExtension
    {
        public static IServiceCollection ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("PostgresConnection");
            var oracleConnectionString = configuration.GetConnectionString("OracleConnection");
            
            //services.AddDbContext<DbContext>(opt => opt.UseNpgsql(connectionString));
            services.AddDbContext<AppDbContext>(opt => opt.UseOracle(oracleConnectionString));
            services.AddScoped<IArticle, ArticleRepository>();
            services.AddScoped<ITag, TagRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}