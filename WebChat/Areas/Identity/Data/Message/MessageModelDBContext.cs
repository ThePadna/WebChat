using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChat.Models;

namespace WebChat.Areas.Identity.Data.Message
{
    public class MessageModelDBContext : DbContext
    {
        public MessageModelDBContext(DbContextOptions<MessageModelDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MessageModel>().ToTable("Message");
        }
    }
}
