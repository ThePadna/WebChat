using Microsoft.EntityFrameworkCore;
using WebChat.Models;

namespace WebChat.Areas.Identity.Data.Message
{
    public class MessageModelDBContext : DbContext
    {
        public DbSet<MessageModel> messageList { get; set; }

        public MessageModelDBContext(DbContextOptions<MessageModelDBContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MessageModel>().ToTable("Message");
        }
    }
}
