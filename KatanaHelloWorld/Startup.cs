using Owin;

namespace KatanaHelloWorld
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseFileServer(false);
            app.MapSignalR();
            var config = new WebApiHttpConfiguration();
            app.UseWebApi(config); 
        }
    }
}
