using Microsoft.Owin;
using Owin;
using System;
using System.Web.Http;

[assembly: OwinStartup(typeof(AIT.Xtime.WebHost.Startup))]
namespace AIT.Xtime.WebHost
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.

        public void Configuration(IAppBuilder appBuilder)
        {
            // Hang the web API off off the /api "sub"-url

            Console.WriteLine($"Server mapped to {"/api"}");
            appBuilder.Map("/api", api =>
            {
                // Create config object to configure the API

                var config = new HttpConfiguration();

                // Use attribute routing

                config.MapHttpAttributeRoutes();

                // Add in the WebAPI middleware

                api.UseWebApi(config);
            });

            appBuilder.UseNancy();
        }
    }
}