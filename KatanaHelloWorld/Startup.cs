using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

namespace KatanaHelloWorld
{
    public class Startup
    {
        public void Configuration1(IAppBuilder app)
        {
            app.UseWelcomePage();
        }


        public void Configuration(IAppBuilder app)
        {
            /**app.UseHandlerAsync((req, res) =>
            {
                res.ContentType = "text/plain";
                return res.WriteAsync("Hallo bert");
            });*/
            var config = new HubConfiguration {  };
            //config.
            // app.MapHubs(config);
            app.UseWelcomePage();

            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);
                map.RunSignalR(new HubConfiguration { EnableJSONP = true });
            });

        }


    }
}
