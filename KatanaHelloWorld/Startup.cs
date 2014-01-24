using Owin;

namespace KatanaHelloWorld
{
    public class Startup
    {
        public void Configuration1(IAppBuilder app)
        {
            app.UseWelcomePage();
        }



    }
}
