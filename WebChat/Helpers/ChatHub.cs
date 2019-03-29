using Microsoft.AspNetCore.SignalR;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using WebChat.Areas.Identity.Data.Message;
using WebChat.Models;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public MessageModelDBContext _messageModelDBContext;

        public ChatHub(MessageModelDBContext messageModelDBContext)
        {
            this._messageModelDBContext = messageModelDBContext;
        }

        public async Task SendMessage(string user, string message)
        {
            MessageModel m = new MessageModel(user, message, new DateTime());
            this._messageModelDBContext.messageList.Add(m);
            this._messageModelDBContext.SaveChanges();
            Debug.WriteLine("Added");
            foreach (MessageModel m1 in this._messageModelDBContext.messageList)
            {
                Debug.WriteLine("Element: " + m1.Sender + ":" + m1.Contents);
            }
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}