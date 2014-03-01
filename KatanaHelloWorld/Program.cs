using System;
using System.Threading;
using Microsoft.Owin.Hosting;

namespace KatanaHelloWorld
{
    public class Program
    {
        private static ManualResetEvent _quitEvent = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            var server="*";
            var port = 5000;
            #if DEBUG
                server = "localhost";
            #endif               

            if (args.Length > 0)
            {
                int.TryParse(args[0], out port);
            }

            Console.CancelKeyPress += (sender, eArgs) =>
            {
                _quitEvent.Set();
                eArgs.Cancel = true;
            };
            using (WebApp.Start<Startup>(string.Format("http://{0}:{1}", server, port)))
            {
                Console.WriteLine("Started");
                _quitEvent.WaitOne();
            }
        }
    }
}