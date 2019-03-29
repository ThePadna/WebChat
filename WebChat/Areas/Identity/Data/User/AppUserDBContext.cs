using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebChat.Areas.Identity.Data
{
    public class AppUserDBContext : IdentityDbContext<AppUser>
    {
        public DbSet<AppUser> userList { get; set; }

        public AppUserDBContext(DbContextOptions<AppUserDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>().ToTable("User");
        }
    }
}
