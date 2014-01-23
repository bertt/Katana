using Owin;

namespace KatanaHelloWorld
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWelcomePage();
        }
    }
}
