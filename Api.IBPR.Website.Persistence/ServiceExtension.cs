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
            
            services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString));
            services.AddScoped<IVerse, VerseRepository>();
            services.AddScoped<ISection, SectionRepository>();
            services.AddScoped<IMainVerse, MainVerseRepository>();
            services.AddScoped<IArticle, ArticleRepository>();
            services.AddScoped<ITag, TagRepository>();
            services.AddScoped<ICoverImage, CoverImageRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            

            return services;
        }
    }
}