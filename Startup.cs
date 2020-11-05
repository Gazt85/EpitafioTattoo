using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EpitafioTattoo.Data;
using Syncfusion.Blazor;

namespace EpitafioTattoo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddSyncfusionBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzQ3MTUzQDMxMzgyZTMzMmUzMEVKQ0JvZThSRDYyZGpLMUdHeTNTakphSzJtekgwUG03dGN5NDRQV1lEckU9;MzQ3MTU0QDMxMzgyZTMzMmUzMGZIQTJqQU91Q1BUbmMzMmNGRXhqMmxTYWpST085SWd2SkNvcmNmYXdvamM9;MzQ3MTU1QDMxMzgyZTMzMmUzMEovQTErMExuV3ZXN2VrU0JtVFVxeXAxQWE2bFZkbldXSnJEUjVPeXJKSG89;MzQ3MTU2QDMxMzgyZTMzMmUzMGVQOFNUUWlEdzV3T1Q3bktpMGFVMmt4M1c5bWhVNGU5eFFIeVRTWlJmMVE9");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
