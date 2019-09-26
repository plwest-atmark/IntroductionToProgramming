using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using _18_WebDev_Middleware.Data;
using _18_WebDev_Middleware.Models;
using _18_WebDev_Middleware.Services;

namespace _18_WebDev_Middleware
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see https://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets<Startup>();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //? The "pipeline" is the systematic process of handling http requests and responses.  The order that
        //? this "pipeline" is in makes a large difference.  If this is not configured properly, then
        //? your request pipeline will not function as expected.  For example, if we put "app.UseMvc"
        //? before everything else, then nothing after this will be able to handle requests.  This piece
        //? of middleware is the piece that routes all of our http requests and is usually the one that 
        //? also generates the response.  ASP.Net configures this method in such as way as to be what is
        //? considered the best practice of setup, however, this is not strict and can be changed if there
        //? are special requirements for the handling of http requests and responses.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            //! Middleware - This is a piece of middleware that we can look at. It provides logging
            //! services for the application. The loggerFactory is injected upon starting the web
            //! applicaton and will be the first piece of middleware that any http request will receive.
            //! 
            //! The logger can be used to log information such as IP Address, time of receiving the request,
            //! any any custom information that you want your website to log when a requeset comes in.
            //!
            //! After the logger "handles" the incomming request, it can then either return a response,
            //! in which case, nothing after the logger will have a chance to see the request and do anything
            //! with it.  The other thing it can do is pass the request on to the next piece of middleware.
            //!
            //! ;
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();


            //! This is not exactly middleware, but does configure certain aspects of our website. There are many
            //! things that we may want the development environment to do that we do not want other environments
            //! to do. Expecially something like using the developer exception page as this is a security risk.
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            //! This is a piece of middleware that allows us to "serve" static files. This means that if we
            //! place a file like an image in the wwwroot folder, we can navigate to that and send just the image
            //! in the response.  This is used for things like downloads and dispalying larger images from thumbnails.
            app.UseStaticFiles();

            //! This piece of middleware is used for security and authentication. It allows us to use any database
            //! for user and user information. This includes passwords and secure information.
            //!
            //! In previous versions of ASP.Net, the configuration of this was much more difficult, and please visit
            //! the link below to see how the other pieces of middleware that work with the Identity Server
            //! are used and what they are for.
            app.UseIdentity();

            // Add external authentication middleware below. To configure them please see https://go.microsoft.com/fwlink/?LinkID=532715


            //! This is the final piece of middleware in our pipeline. It will handle any http request that is
            //! in the format of the routes that are described and included within the {}. In this case, any
            //! http request that has the form of {controller}{action}{id?} will be processed. This middleware
            //! will look for a controller with the same name, an action with the same name and IF provided pass
            //! the id to the action as a parameter.  The ? indicates that this is optional. Also, if a request comes
            //! into the server without an url, it will direct the request to the default page configured.
            //! Home /Index ({controller=Home}{action=Index}{id?})
            //!
            //! This is a power piece of middleware and allows us create many routes with different patterns.
            //!
            //! Note, for this to work you must have the MVC service which is configured above with the
            //! "service.AddMvc();"
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
