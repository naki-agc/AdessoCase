using AdessoCase.Application.Queries.Game;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AdessoCase.Application
{
    public static class ServiceRegistration
    {
        public static void ApplicationRegister(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly()
                       .ExportedTypes
                       .Where(cs => cs.FullName != null && cs.FullName.Contains("Handler") && cs.IsClass)
                       .ToArray();
            //içinde handler geçen classları alıp register et.
            services.AddMediatR(assembly);
            services.AddFluentValidation(fv =>
            {
                fv.RegisterValidatorsFromAssemblyContaining<GameValidation>();
                fv.DisableDataAnnotationsValidation = true;
            });
        }
    }
}
