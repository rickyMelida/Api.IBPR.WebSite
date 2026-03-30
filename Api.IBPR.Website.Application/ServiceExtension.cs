using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Application.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Api.IBPR.Website.Application
{
    public static class ServiceExtension
    {
        public static void ConfigureApplication(this IServiceCollection services)
        {
            services.AddScoped<IVerseServices, VerseService>();
            services.AddScoped<ICoverImagesService, CoverImagesService>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddMediatR(typeof(ServiceExtension).Assembly);
        }
    }
}
