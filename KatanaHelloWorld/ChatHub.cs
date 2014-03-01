using Microsoft.AspNet.SignalR;

namespace KatanaHelloWorld
{
    public class MyHub : Hub
    {
        public void Send(string message)
        {
            // iedereen
            Clients.All.addMessage(message);
        }
    }
}
