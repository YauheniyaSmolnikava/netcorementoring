using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreTestApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using NetCoreTestApp.Interfaces;
using NetCoreTestApp.Repositories;
using Microsoft.AspNetCore.Routing.Constraints;
using NetCoreTestApp.Middleware;

namespace NetCoreTestApp
{
    public class Startup
    {
        private readonly ILogger<Startup> _logger;

        public Startup(IConfiguration configuration, ILogger<Startup> logger)
        {
            Configuration = configuration;
            _logger = logger;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            var connection = Configuration.GetConnectionString("DefaultConnection");
            _logger.LogInformation($"Configuration param has been retrived: DefaultConnection: {connection}");
            services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(connection));
            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddScoped<ICategoriesRepository, CategoriesRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseStatusCodePages();

            app.UseImagesCache(new ImagesCacheOptions
            {
                CacheDirectory = "cache",
                MaxCachedImagesCount = 5,
                CahceExpirationTimeInMinutes = TimeSpan.FromMinutes(1),
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "images",
                    template: "images/{id}",
                    defaults: new { controller = "Categories", action = "GetImage" },
                    constraints: new { id = new IntRouteConstraint() }
                );
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
