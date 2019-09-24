using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace _16_IntroToWebDevelopment
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// This is the method in a web application where all the configuration occur.  We call this
        /// this pipeline, and it is where all the middleware is established.  Middelware are components
        /// that take a web request and do some "process" for that request.   In this case, we are
        /// configuring the following:
        /// 
        /// 1.  Setup a Console for the loggerFactory. This will add a console support for the logger
        ///         so we will be able to put log messages in our application and have them be seen
        ///         in the display here for easy use.  This is something that is helpful for development
        ///         because we can log activities or runtime information without having to stop our
        ///         application. This becomes more important when there is multi-threading and debugging
        ///         is more difficult because of the threads.  The newer version of Visual Studios allow
        ///         us to debug multi-threads relatively easy, however, at times it's still easier to 
        ///         log information and analyze it in a console.
        ///         
        /// 2.  Setup a "Developer Exception Page", but only when in the development environment.  This is
        ///         very helpful as the new ASP provides a nice web page for error handling that gives
        ///         the developer a lot of information about what went wrong when a web site errors.  This
        ///         should only be displayed when in a development environment because of the information
        ///         that it provides can cause a security risk for the web site, servers, personal
        ///         information, etc...
        ///         
        /// 3.  The "blank" template that was used for this website gives a basic Http response that will
        ///         send a simple string back in the response.  There is actually a lot happening here,
        ///         but for now we can just say that we are writing to a web page instead of writing to
        ///         a Console application as we have done before.  The concepts are similar with coding,
        ///         but the process is quite complex behind the code we see here.
        ///         
        /// NOTE:   Every argument in this constructor is an interface. This is how we utilize
        ///         dependency injection.  ASP.Net Core has built in dependency injection for
        ///         many items. Later we will learn how to expand this dependency injection for
        ///         all of our needs when creating controllers and other business logic in a 
        ///         web application.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="loggerFactory"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            // This is a call that builds an http request to send a string message to the
            // process.  If you run the program, a web page will be displayed that 
            // simply has "Hello World!" as text in the upper left corner.
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
