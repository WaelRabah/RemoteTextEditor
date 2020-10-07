using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Text_Editor_Backend
{
    public class Chat : Hub
    {
        public Task SendText(string text)
        {
            return Clients.All.SendAsync("ReceiveMessage", text);
        }
    }
}