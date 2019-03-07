using System.Linq;
using WebChat.Areas.Identity.Data;
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
            var users = new AppUser[]
            {
                new AppUser {usertag="User1", colour="#cc0066"},
                new AppUser {usertag="User2", colour="#6600cc"}
            };
            foreach (AppUser user in users)
            {
                context.userList.Add(user);
            }
            context.SaveChanges();
        }
    }
}