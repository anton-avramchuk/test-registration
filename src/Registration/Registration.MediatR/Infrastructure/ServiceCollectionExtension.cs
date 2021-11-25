using System;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Registration.MediatR.Common;
using Registration.MediatR.Services;

namespace Registration.MediatR.Infrastructure
{
    public static class ServiceCollectionExtension
    {


        public static IServiceCollection RegisterMediatorModule(this IServiceCollection services, Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));
            services.AddMediatR(assembly);
            return services;
        }


        public static IServiceCollection AddMediatorModule(this IServiceCollection services)
        {
            services.AddTransient<IMediatorService, MediatorService>();
            return services;
        }
    }
}