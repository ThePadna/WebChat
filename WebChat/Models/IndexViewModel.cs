using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChat.Areas.Identity.Data;

namespace WebChat.Models
{
    public class IndexViewModel
    {
        public DbSet<AppUser> _userList { get; set; }
        public DbSet<MessageModel> _messageList { get; set; }

        public IndexViewModel(DbSet<AppUser> userList, DbSet<MessageModel> messageList)
        {
            this._userList = userList;
            this._messageList = messageList;
        }
    }
}
