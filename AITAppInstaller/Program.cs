using AIT.Xtime.WebHost;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITAppInstaller
{
    internal static class Program
    {
        private static IDisposable _server;
        public static string baseAddress = "http://localhost:38099";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _server = WebApp.Start<Startup>(url: baseAddress);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
