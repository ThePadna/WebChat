using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChat.Areas.Identity.Data
{
    public class AppUser : IdentityUser
    {
        public string Colour { get; set; }
    }
}
