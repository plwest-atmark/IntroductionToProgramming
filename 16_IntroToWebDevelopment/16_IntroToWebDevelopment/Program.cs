using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace _16_IntroToWebDevelopment
{
    public class Program
    {
        /// <summary>
        /// In a web application, just like a Console application, the Main method is the starting
        ///     or entry point for the program.  Unlike a console application we do not really do
        ///     many things within the Main method.  We do, however, setup a WebHost and run the host.
        ///     The host then handles incomming Http Request and Http Responses
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                // setups using the Kestrel server for our host processes. We will discuss more in a
                // following lesson. The Kestrel server is one of many ways to "host" our website.
                // All websites need a "host" that will handling the incomming and outgoing calls for
                // a website.
                .UseKestrel() 

                // sets the "root" of our web application and establishes the 
                // "folder and file" structure.  This is needed to ensure that the 
                // "framework" knows where to look for things like models, views, 
                //controllers, and wwwroot
                .UseContentRoot(Directory.GetCurrentDirectory()) 

                // This, like Kestrel, is a hosting service that can be used for our web application.
                .UseIISIntegration()

                //TODO THIS NEEDS NOTES
                .UseStartup<Startup>()

                //TODO THIS NEEDS NOTES
                .UseApplicationInsights()

                // "Builds" the host.  This is always the last thing called, because all of the configuration
                // for the host needs to be established before being built. 
                .Build();


            // Now that we have a web host to handling incomming and outgoing requests, we need to
            // tell it to start and beging "listening" for http requests on a specific port.
            host.Run();
        }
    }
}
