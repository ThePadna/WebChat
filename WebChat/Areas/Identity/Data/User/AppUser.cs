using Microsoft.AspNetCore.Identity;

namespace WebChat.Areas.Identity.Data
{
    public class AppUser : IdentityUser
    {
        public string Colour { get; set; }
    }
}
