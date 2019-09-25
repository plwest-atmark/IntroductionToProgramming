using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace _17_WebDev_Configuration
{
    public class Startup
    {
        // This is the private configuration variable that we will use as our service. This is set in the constructor
        // and can be used through out this file to access the appsettings.json settings.
        private IConfiguration _config;
        /// <summary>
        /// In ASP.Net 1.1 which we are using for our book, this cannot be done. However, with the latest
        /// version of ASP.Net core, you can dependency inject the IConfiguration service into your Startup
        /// class and use it easily.  We are using ASP.Net 1.1 for this class, and therefore we have to do
        /// something a little different. However, the explaination for 2.0+ is below with a constructor for
        /// the class to demonstrate, it is however, commented out because this does not work in ASP.Net 1.1
        /// 
        /// 
        /// ASP.Net Core is built with an Inversion of Control Container (IOC). This allows us to use
        /// dependency injection for classes that have an interface.  ASP.Net is already configured to inject
        /// the correct IConfiguration concrete object when this class is created. We do not have to worry about
        /// the way this is done. However, if you are curious and want to learn more about IOC and dependency
        /// injection, both the source code and IOC container tutorials are available on the web.  This is an
        /// advanced topic in programming and will not be covered in this class.  Just know that there are many
        /// things that have already been done for us, and with any good OOP, we don't have to worry about how
        /// things are done, we are able to use them as long as we know how to use them
        /// 
        /// In this case, the IConfiguration will allow us to access our values in the appsettings.json files.
        /// </summary>
        /// <param name="config"></param>
        //public Startup(IConfiguration config)
        //{
        //    _config = config;
        //}
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // In versions of ASP.Net before 2.0, you have to build your configuration in this way.
            // After 2.0, you can use dependency injection on the Startup class constructor
            // to do this. Since our book is using 1.1, we will use this as our method for creating
            // our configuration.  
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            _config = builder.Build();


            // Add logger
            loggerFactory.AddConsole();


            // add dev error page
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            // get our setting and use it.
            app.Run(async (context) =>
            {
                // previously we were simply writing the string "Hello World" to our webpage. Now, let's use our
                // custom vallue that we put in the appsettings.json file. This will show you how we can access
                // the key/value pairs that we will use through-out the rest of the web application.

                //? To use the appsettings.json values, we simply have to "get the value from the key"
                //? this can be done by using our private _config variable and the key in version 2.0+.
                //?     _config["MyCustomKey"]

                //? In the version of ASP.Net that we are using, we have to use the GetValue<T> method
                //? to get our string.

                //! NOTE: If the key is not available in the appsettings.json file, an exception will be thrown
                //!         and your web application will be broken.

                var myCustomValue = _config.GetValue<string>("MyCustomSetting"); // ASP.Net 1.1
                //var myCustomValue = _config["MyCustomSetting"]; // ASP.NET 2.0+
                await context.Response.WriteAsync(myCustomValue);
            });
        }
    }
}
