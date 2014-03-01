using Microsoft.AspNet.SignalR;

namespace KatanaHelloWorld
{
    public class MyHub : Hub
    {
        public void Send(string message)
        {
            // iedereen
            Clients.All.addMessage(message);
            // anderen
            //Clients.Others.addMessage(message);
            // caller
            //Clients.Caller.addMessage(message);

            //var i=Context.User.Identity.Name;
        }
    }
}
