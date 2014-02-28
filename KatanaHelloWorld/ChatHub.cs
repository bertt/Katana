using Microsoft.AspNet.SignalR;

namespace KatanaHelloWorld
{
    public class MyHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.addMessage(message);
        }
    }
}
