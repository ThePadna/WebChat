using System;
using System.Linq;
using WebChat.DAL;
using WebChat.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();
            if(context.users.Any())
            {
                return;
            }
            var users = new UserModel[]
            {
                new UserModel {Id="User1", hashedPassword="Pass1"},
                new UserModel {Id="User2", hashedPassword="Pass2"}
            };
            foreach (UserModel user in users)
            {
                context.users.Add(user);
            }
            context.SaveChanges();
        }
    }
}