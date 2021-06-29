using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Football_manager.Models;

namespace Football_manager
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
            string mySqlConnectionStr = Configuration.GetConnectionString("DefaultConnection");
            //  string mySqlConnectionStr = Configuration.GetConnectionString("OtherConnection");
            // services.AddDbContextPool<MyDBContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));
            services.AddDbContextPool<FootballManagerDBContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));
            // //  services.AddTransient<IPlayerRepository, FakePlayerRepository>();
            services.AddTransient<IPlayerRepository, EFPlayerRepository>();
            services.AddMvc();
            //services.AddControllersWithViews(); 

            services.AddControllersWithViews(mvcOtions =>
            {
                mvcOtions.EnableEndpointRouting = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {

                routes.MapRoute(
               name: null,
               template: "Team/{team}/Page{Page:int}",
               defaults: new
               {
                   controller = "Player",
                   action = "List",
                   Page = 1
               });
                routes.MapRoute(
                name: null,
                template: "",
                defaults: new
                {
                    controller = "Player",
                    action = "List",
                    Page = 1
                });

                routes.MapRoute(
                name: null,
                template: "Game/{firstteam}/Page{Page:int}",
                defaults: new
                {
                    controller = "Game",
                    action = "List",
                    Page = 1
                });

                //routes.MapRoute(
                //name: null,
                //template: "",
                //defaults: new
                //{
                //    controller = "Game",
                //    action = "List",
                //    Page = 1
                //});

                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");


                // routes.MapRoute(
                //name: null,
                //template: "Player/{team}/Page{Page:int}",
                //defaults: new
                //{
                //    controller = "Player",
                //    action = "List",
                //    Page = 1
                //});


                // routes.MapRoute(
                // name: null,
                // template: "Player",
                // defaults: new
                // {
                //     controller = "Player",
                //     action = "List",
                //     Page = 1
                // });

                // routes.MapRoute(
                // name: null,
                // template: "Game/{firstteam}/Page{Page:int}",
                // defaults: new
                // {
                //     controller = "Game",
                //     action = "List",
                //     Page = 1
                // });

                // routes.MapRoute(
                // name: null,
                // template: "Game",
                // defaults: new
                // {
                //     controller = "Game",
                //     action = "List",
                //     Page = 1
                // });

                // routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");


















                //routes.MapRoute(Player/Page{PlayerPage}
                //name: null,
                //template: "{firstteam}/Page{Page:int}",
                //defaults: new
                //{
                //    controller = "Game",
                //    action = "List"
                //});
                //routes.MapRoute(
                //name: null,
                //template: "",
                //defaults: new
                //{
                //    controller = "Game",
                //    action = "List",
                //    Page = 1
                //});
                //routes.MapRoute(
                //name: null,
                //template: "{firstteam}",
                //defaults: new
                //{
                //    controller = "Game",
                //    action = "List",
                //    Page = 1
                //}
                //);



















                //             routes.MapRoute(
                //                 name: "default",
                //      template: "{controller=Game}/{action=List}/{id?}");
                //             routes.MapRoute(
                //name: "pagination",
                //template: "Game/Page{Page}",
                //defaults: new { Controller = "Game", action = "List" });

                //                routes.MapRoute(
                //name: null,
                //template: "{team}/Page{PlayerPage:int}",
                //defaults: new { controller = "Player", action = "List" }
                //);
                //                routes.MapRoute(
                //                name: null,
                //                template: "Page{PlayerPage:int}",
                //                defaults: new
                //                {
                //                    controller = "Player",
                //                    action = "List",
                //                    productPage = 1
                //                }
                //                );


                //                routes.MapRoute(
                //                name: null,
                //                template: "{team}",
                //                defaults: new
                //                {
                //                    controller = "Player",
                //                    action = "List",
                //                    productPage = 1
                //                }
                //                );


                //                routes.MapRoute(
                //name: null,
                //template: "",
                //defaults: new
                //{
                //    controller = "Player",
                //    action = "List",
                //    productPage = 1
                //});
                //        routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");

                ////             routes.MapRoute(
                ////name: "pagination",
                ////template: "Player/Page{PlayerPage}",
                ////defaults: new { Controller = "Player", action = "List" });


                ////       routes.MapRoute(
                ////           name: "default",
                ///////    template: "{controller=Home}/{action=Index}/{id?}");
                ////template: "{controller=Player}/{action=List}/{id?}");
            });
            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}
