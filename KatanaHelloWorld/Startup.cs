using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace KatanaHelloWorld
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseFileServer(false);
            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);
                map.RunSignalR(new HubConfiguration { EnableJSONP = true });
            });
            var config = new MyHttpConfiguration();
            app.UseWebApi(config); 
        }
    }
}
