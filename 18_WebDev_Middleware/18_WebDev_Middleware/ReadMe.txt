
In this solution we will talk about middleware.  When an http request comes in, there are many things that can happen. Middleware is all
off the processes that handle the request. Each one takes the request, does what it is meant to do with it, and either passes it to the next
piece of middleware or returns the request as a response.

We will look at a couple of pieces of middleware in this solution, but they are not the only pieces of middleware that exist. There are many
things that can be called middleware, and most of them are custom made by the developers based on the needs of the client.  Things like logging,
security, bandwidth throttling, etc are controlled with middleware and are essential to a web application that runs smoothly with thousands
of users at a time.

Look at the Startup.cs and specficially the notes provided in the 
	"Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)"
method. Here is where we configure the middleware and the http request "pipeline". As mentioned, there are more
services that can be utilize than the ones in this solution, however, these are the basic and standard for a "plain"
web application.
