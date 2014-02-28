using Microsoft.AspNet.SignalR;
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
            var config = new HubConfiguration { EnableCrossDomain = true };
            app.MapHubs(config);
            //app.UseWelcomePage();
        }


    }
}
