using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Registration.DataAccess;

namespace Registration.Web.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRegistrationApplicationServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}
