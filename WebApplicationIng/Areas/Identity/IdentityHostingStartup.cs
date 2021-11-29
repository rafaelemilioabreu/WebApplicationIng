using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationIng.Areas.Identity.Data;
using WebApplicationIng.Data;

[assembly: HostingStartup(typeof(WebApplicationIng.Areas.Identity.IdentityHostingStartup))]
namespace WebApplicationIng.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<WebApplicationIngContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebApplicationIngContextConnection")));

                services.AddDefaultIdentity<WebApplicationIngUser>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>()

                    .AddEntityFrameworkStores<WebApplicationIngContext>();
            });
        
        }
    }

}