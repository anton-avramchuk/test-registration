using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Registration.DataAccess;
using Registration.Domain.Identity;

namespace Registration.Web.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRegistrationApplicationServices(this IServiceCollection services)
        {
            return services.AddIdentity();
        }

        private static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>(opt =>
            {
                opt.User.RequireUniqueEmail = true;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireNonAlphanumeric = true;
                opt.Password.RequireDigit = true;
            }).AddSignInManager().AddDefaultTokenProviders();
            services.AddTransient<IUserStore<User>, UserStore<User, Role, ApplicationContext, Guid, UserClaim, UserRole, UserLogin, UserToken, RoleClaim>>();
            services.AddTransient<IRoleStore<Role>, RoleStore<Role, ApplicationContext, Guid, UserRole, RoleClaim>>();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Login";
                options.AccessDeniedPath = options.LoginPath;
            });
            return services;
        }
    }
}
