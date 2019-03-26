using System.Linq;
using WebChat.Areas.Identity.Data;
using WebChat.Areas.Identity.Data.Message;
using WebChat.Models;

namespace WebChat.DAL
{
    public class DbInitializer
    {
        public void Initialize(AppUserDBContext context)
        {
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
        public  void Initialize(MessageModelDBContext context)
        {
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
    }
}