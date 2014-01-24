﻿using System;
using System.Threading;
using Microsoft.Owin.Hosting;

namespace KatanaHelloWorld
{
	public class Program
	{
		private static ManualResetEvent _quitEvent = new ManualResetEvent(false);

		static void Main(string[] args)
		{
			var port = 5000;
			if (args.Length > 0)
			{
				int.TryParse(args[0], out port);
			}

			Console.CancelKeyPress += (sender, eArgs) =>
			{
				_quitEvent.Set();
				eArgs.Cancel = true;
			};
            using (WebApp.Start<Startup>(string.Format("http://*:{0}", port)))
			{
				Console.WriteLine("Started");
				_quitEvent.WaitOne();
			}
		}
}
