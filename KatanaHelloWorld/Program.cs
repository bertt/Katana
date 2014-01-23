using System;
using Microsoft.Owin.Hosting;

namespace KatanaHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            var uri = "http://localhost:8080/";

            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Started");
                Console.ReadKey();
                Console.WriteLine("Stopping");
            }

        }
    }
}
