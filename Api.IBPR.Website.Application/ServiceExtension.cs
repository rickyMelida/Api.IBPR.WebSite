using System.Reflection;
using Api.IBPR.Website.Application.Interfaces;
using Api.IBPR.Website.Application.Services;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Api.IBPR.Website.Application
{
    public static class ServiceExtension
    {
        public static void ConfigureApplication(this IServiceCollection services)
        {
            services.AddScoped<IVerseServices, VerseService>();
        }
    }
}
