﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebChat.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WebChatUser class
    public class WebChatUser : IdentityUser
    {
        public override string Id { get; set; }
        public string Colour { get; set; }
    }
}
