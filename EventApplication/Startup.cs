using EventApplication.AutoMapper;
using EventApplication.DAL;
using EventApplication.Interfaces;
using EventApplication.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Security.Claims;

namespace EventApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages().AddRazorRuntimeCompilation();

            
            services.AddDbContext<AppDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("AuthConnectionString"),
                    b => b.MigrationsAssembly("EventApplication")));

            AppDBContext.ConnectionString = Configuration.GetConnectionString("AuthConnectionString");
             

            services.AddHttpContextAccessor();
             
            services.AddAutoMapper(c => c.AddProfile<AutoMapperProfile>(), typeof(Startup));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<UsersInterfaces, UsersDAL>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddSession(options =>
            {
                options.Cookie.Name = "AuthCertificate";
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
