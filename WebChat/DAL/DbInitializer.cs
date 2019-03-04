using System.Linq;
using WebChat.Areas.Identity.Data;
using WebChat.Models;

namespace WebChat.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(WebChatContext context)
        {
            context.Database.EnsureCreated();
            if(context.userList.Any())
            {
                return;
            }
            var users = new WebChatUser[]
            {
                new WebChatUser {chatUsername="User1", colour="#cc0066"},
                new WebChatUser {chatUsername="User2", colour="#6600cc"}
            };
            foreach (WebChatUser user in users)
            {
                context.userList.Add(user);
            }
            context.SaveChanges();
        }
    }
}