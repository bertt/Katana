using System.Web.Http;

namespace KatanaHelloWorld
{
    public class TestController:ApiController
    {
        public string GetTest()
        {
            return "hallo from web api";
        }
    }
}
