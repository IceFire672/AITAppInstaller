using Nancy;
using Nancy.Conventions;
using Nancy.TinyIoc;

namespace AIT.DealerSyncClient.WebHost.Website.Configuration
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            // Add a view location convention that looks for views in a folder
            //  named "views" next to the module class
            //
            Conventions.ViewLocationConventions.Add((viewName, model, context) => $"App/{viewName}");

            // Add a new path for static content so our typescript files located in
            //  the 'App' folder can be served to SystemJS
            //
            Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("", "App"));
        }
    }
}
