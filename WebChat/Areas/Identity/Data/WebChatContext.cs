using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebChat.Areas.Identity.Data;

namespace WebChat.Models
{
    public class WebChatContext : IdentityDbContext<WebChatUser>
    {
        public WebChatContext(DbContextOptions<WebChatContext> options) : base(options)
        {
        }

        public DbSet<WebChatUser> userList { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<WebChatUser>().ToTable("WebChatUser");
            base.OnModelCreating(builder);
        }
    }
}
