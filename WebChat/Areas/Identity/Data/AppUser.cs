using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChat.Areas.Identity.Data
{
    public class AppUser : IdentityUser
    {
        public string usertag { get; set; }
        public string colour { get; set; }
    }
}
