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

namespace Day1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //depence injection
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSession(c =>
            {
                c.IdleTimeout = TimeSpan.FromMinutes(10);
                
            });
        }

        // This method gets called by the runtime.
        // Use this method to configure the HTTP request pipeline -set of middleware component.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region inline middleware ==>anynoms function
            //app.Use(async (context, next) => {
            //    //can add response or not 
            //    await context.Response.WriteAsync("1) MiddleWare 1_1\n");
            //    //can call next middler or not "short cirle
            //    await next.Invoke();

            //    await context.Response.WriteAsync("5) MiddleWare 1_2\n");
            //});

            //app.Use(async (context, next) => {
            //    //can add response or not 
            //    await context.Response.WriteAsync("2) MiddleWare 2-1\n");
            //    //can call next middler or not "short cirle                
            //    await next.Invoke();

            //    await context.Response.WriteAsync("4) MiddleWare 2_2\n");
            //});

            //app.Run(async (context) => {
            //    await context.Response.WriteAsync("3) Ternimate\n");
            //});
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

            app.UseSession();

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
