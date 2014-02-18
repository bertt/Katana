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
                return res.WriteAsync("Hallo hallo");
            });*/
            app.UseWelcomePage();
        }


    }
}
