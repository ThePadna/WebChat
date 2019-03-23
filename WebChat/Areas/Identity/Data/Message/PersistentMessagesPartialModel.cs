using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChat.Models;

namespace WebChat.Models
{
    public class PersistantMessagesPartialModel
    {
        public static ICollection<MessageModel> Messages = new List<MessageModel>() { new MessageModel {Contents = "Test", Date = new DateTime(), Sender = "User"} };
    }
}
