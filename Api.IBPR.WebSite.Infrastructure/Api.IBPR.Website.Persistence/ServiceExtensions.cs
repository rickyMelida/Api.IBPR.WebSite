using Api.IBPR.Website.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.IBPR.Website.Infrastructure.Api.IBPR.Website.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("OracleConnection");
            services.AddDbContext<OracleDbContext>(opt => opt.UseOracle(connectionString));
            //services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString));

            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}