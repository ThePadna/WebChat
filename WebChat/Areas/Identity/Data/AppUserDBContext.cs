using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChat.Areas.Identity.Data
{
    public class AppUserDBContext : IdentityDbContext<AppUser>
    {
        public AppUserDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> userList { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>().ToTable("User");
        }
    }
}
