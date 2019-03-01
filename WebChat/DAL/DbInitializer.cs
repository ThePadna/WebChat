using System;
using System.Linq;
using WebChat.Areas.Identity.Data;
using WebChat.DAL;
using WebChat.Models;

namespace ContosoUniversity.Data
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
                new WebChatUser {Id="User1", Colour="#cc0066"},
                new WebChatUser {Id="User2", Colour="#6600cc"}
            };
            foreach (WebChatUser user in users)
            {
                context.userList.Add(user);
            }
            context.SaveChanges();
        }
    }
}