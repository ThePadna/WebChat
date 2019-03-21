using System.Linq;
using WebChat.Areas.Identity.Data;
using WebChat.Areas.Identity.Data.Message;
using WebChat.Models;

namespace WebChat.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(AppUserDBContext context)
        {
            context.Database.EnsureCreated();
            if(context.userList.Any())
            {
                return;
            }
            AppUser[] users = new AppUser[]
            {
                new AppUser {UserName = "ChatBot", Colour="#c19e3e"}
            };
            foreach (AppUser user in users)
            {
                context.userList.Add(user);
            }
            context.SaveChanges();
        }
        public static void Initialize(MessageModelDBContext context)
        {
            context.Database.EnsureCreated();
            if(context.messageList.Any())
            {
                return;
            }
            MessageModel[] messages = new MessageModel[]
            {
                new MessageModel {Sender = "Nalo", Date = new System.DateTime(), Contents = "I AM A MONSTE43RRR"}
            };
            foreach (MessageModel msg in messages)
            {
                context.messageList.Add(msg);
            }
            context.SaveChanges();
        }
    }
}