using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MVCBasicsAssignment
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(5);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseDefaultFiles();

            app.UseRouting();


            app.UseAuthorization();

            app.UseSession();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "numberGuess",
                pattern: "GuessingGame/{id?}",
                defaults: new { controller = "Services", action = "GuessingGame" });

                endpoints.MapControllerRoute(
                name: "feverCheck",
                pattern: "FeverCheck/{id?}",
                defaults: new { controller = "Services", action = "FeverCheck" }); 

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}