

This solution will explain the appsettings.json and appsettings.{environment}.json files and how to use them in a web application.  
There are 4 ways to configure a web application and each of these methods are used in specific ways to provide not only flexibility, 
but also security to our web application.

ASP.Net has been designed and built with the IConfigurationService and knows how to read settings from the appsettings.json and the 
appsettings.{environment}.json files by default. We do not have to do anything more than this since the IConfigurationService is injected
in our Startup.cs file.  When we build our host in the program.cs files, we utilize the method "UseStartup<Startup>()" which tells the host
to utilize this file when it is being constructed. It will then use the methods in this file to assist with the building of the host. Within 
the current program.cs file we have the method "Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)".

This method "Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)" is the method that we create and use our
configuration.  In ASP.Net 1.1, this has to be done manually. However, in versions of ASP.Net 2.0+, this can be done with dependency injection
in the constructor.  I have placed the code for 2.0+ in the source, but it is currently commented out because we are working in ASP.Net 1.1.



The four ways for configuration your web application are as follows:

	1.) Files (appsettings.json, appsettings.{environment}.json)
	2.) User Secrets
	3.) Environment Variables
	4.) Command Line Arguments

We will only discuss the appsettings.json and appsettings.{environment}.json file in this solution, and we will discuss the Environment Variables portion
in class as this requires use of the Windows Operation System settings and cannot be easily discussed within a solution program.

In this solution there is an appsettings.json file and an appsettings.development.json file. Each of them have a "MyCustomSetting" setting, but the
values of each of them are different.

Within the "launchSettings.json" under the Properties in the Solution Explorer you will find different "sections" where you can configure
how your application is "launched". It's a way to emulate running in different environments, even while you're on your developoment machine.
This allows us to see the behavior of the application on different environments to ensure that things are working as expected over all the
environments and not just on our development machine.  There is a joke in Development that is said when something goes wrong in production
or staging and the developers are having difficulty determine exactly what the problem is.  "Works on my machine!"... hahaha

So, under the "Environment_Variables" setting in the launchSettings.json, if you change it between "development" and anything else, you can see
that the settings variable that is retreived is different.  This is how we make custom settings for different environments.