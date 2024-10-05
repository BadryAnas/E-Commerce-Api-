﻿using Microsoft.AspNetCore.Identity;
using Store.Data.Contexts;
using Store.Data.Entities.IdentityEntities;

namespace Store.Web.Extensions
{
    public static class IdentityServicesExtension
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<AppUser>();

            builder = new IdentityBuilder(builder.UserType , builder.Services);

            builder.AddEntityFrameworkStores<StoreIdentityDbContext>();

            builder.AddSignInManager<SignInManager<AppUser>>();

            services.AddAuthentication();

            return services;

        }
    }
}
