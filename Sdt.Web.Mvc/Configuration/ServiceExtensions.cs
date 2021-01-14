using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sdt.Data.Context;
using Sdt.Data.Contracts;
using Sdt.Data.Repository;
using Sdt.Web.Mvc.Controllers;
using Sdt.Web.Mvc.Data;

namespace Sdt.Web.Mvc.Configuration
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            //Sdt
            services.AddDbContext<SdtDataContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            //identity
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
        }

        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IAutorRepository, AutorRepository>();
        }
    }
}
