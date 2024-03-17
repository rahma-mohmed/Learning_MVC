using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day2_2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region inlineMiddleware
            app.Use(async(context , next) => {
                await context.Response.WriteAsync("1_1) MiddleWare \n");
                await next.Invoke();
                await context.Response.WriteAsync("1_2) MiddleWare \n");
            });

            app.Use(async (context, next) => {
                await context.Response.WriteAsync("2_1) MiddleWare \n");
                await next.Invoke();
                await context.Response.WriteAsync("2_2) MiddleWare \n");
            });

            app.Run(async (context) => {
                await context.Response.WriteAsync("3) MiddleWare \n");
            });

            app.Use(async (context , next) => {
                await context.Response.WriteAsync("4) MiddleWare \n");
                await next.Invoke();
            });

            #endregion
            #region built middleware Component
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            #endregion
        }
    }
}
