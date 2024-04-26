using Nancy;

namespace AIT.Xtime.WebHost.Website.Modules
{
    public class RootModule : NancyModule
    {
        public RootModule()
        {
            // Define a single route that returns our index.html view
            //
            Get("/", _ => {
                return View["index"];
            });
            Get("/home", _ => {
                return View["index"];
            });
        }
    }
}
