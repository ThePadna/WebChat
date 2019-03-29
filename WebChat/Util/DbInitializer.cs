using Microsoft.EntityFrameworkCore;
using WebChat.Areas.Identity.Data;
using WebChat.Areas.Identity.Data.Message;

namespace WebChat.DAL
{
    public class DbInitializer
    {
        public void Initialize(AppUserDBContext context)
        {
            context.Database.EnsureCreated();
            context.Database.Migrate();
            context.SaveChanges();
        }
        public  void Initialize(MessageModelDBContext context)
        {
            context.Database.EnsureCreated();
            context.Database.Migrate();
            context.SaveChanges();
        }
    }
}