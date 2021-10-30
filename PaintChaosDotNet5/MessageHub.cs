using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace PainChaos5
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(string msg)
        {
            await Clients.All.SendAsync("ReceiveMessage", msg);
        }
    }
}
