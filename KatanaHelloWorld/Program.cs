using System;
using Microsoft.Owin.Hosting;

namespace KatanaHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            var uri = "http://localhost:8080/";

            var port = 5000;
            if (args.Length > 0)
            {
                int.TryParse(args[0], out port);
            }
            using (WebApp.Start<Startup>(string.Format("http://*:{0}", port)))
            {
                Console.WriteLine("Started");
                Console.ReadKey();
                Console.WriteLine("Stopping");
            }

        }
    }
}
