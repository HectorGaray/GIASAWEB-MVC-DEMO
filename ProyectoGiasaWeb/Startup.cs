using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoGiasaWeb.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProyectoGiasaWeb
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("StringConnection")));
            //services.AddDefaultIdentity<IdentityUser>()
            services.AddIdentity<IdentityUser, IdentityRole>()// manejo de usuarios y roles de asp
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.ConfigureApplicationCookie(options =>// configuracion de cookies
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(1);// tiempo de expiracion de un 1
                options.LoginPath = "/Home/Index";// redireccion de coockies
            });

            services.AddSession(options =>// variables de seesion de las cookies son independientes
            {
                options.Cookie.Name = ".SistemaGiasa.Session";//nombre de la coockie  
                options.IdleTimeout = TimeSpan.FromHours(12);// 12 horas de la cookie
                
            });// se reinicia con cada usuario, Variables de Session 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSession();// activar las variables
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            //app.UseStatusCodePages();
            //app.UseStatusCodePagesWithRedirects("/Error");// (URL bad) Redirecciona a Error si el usuario direcciono mal
            app.UseStatusCodePagesWithReExecute("/Error/Error","?statusCode={0}");
            app.UseHttpsRedirection();// Direccionamiento activado
            app.UseStaticFiles();// uso de archivos estaticos en session
            app.UseCookiePolicy();// aviso de cokkies

            app.UseAuthentication();
            // rutas del sistema
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");


            routes.MapAreaRoute("Principal","Principal", "{controller=Principal}/{action=Index}/{id?}");
            routes.MapAreaRoute("Usuarios", "Usuarios", "{controller=Usuarios}/{action=Index}/{id?}");
            routes.MapAreaRoute("Catalogos","Catalogos", "{controller=Catalogos}/{action=Index}/{id?}");
            routes.MapAreaRoute("Indirectos", "Catalogos", "{controller=Indirectos}/{action=Index}/{id?}");
            routes.MapAreaRoute("Materiales", "Materiales", "{controller=Materiales}/{action=Index}/{id?}");


            });
        }
    }
}
