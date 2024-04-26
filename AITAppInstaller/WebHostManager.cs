using Microsoft.Owin.Hosting;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AIT.Xtime.WebHost
{
    public class WebHostManager
    {
        private static IDisposable _server;
        private static string _baseAddress = "http://localhost:38090/Xtime";
        public static Action ServiceStop { get; set; }
        public static void Start()
        {
            // Start up the server by providing our OWIN Startup class as the source type

            _server = WebApp.Start<Startup>(url: _baseAddress);

            Console.WriteLine($"Server running at {_baseAddress}");
        }

        public static void Stop()
        {
            // Dispose of the server object

            _server?.Dispose();

            Console.WriteLine($"Server stopped at {_baseAddress}");
        }

        public static void RegisterServiceStopEvent(Action serviceStop)
        {
            ServiceStop = serviceStop;
        }
    }
}
