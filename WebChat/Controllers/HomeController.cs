using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebChat.Areas.Identity.Data;
using WebChat.Areas.Identity.Data.Message;
using WebChat.DAL;
using WebChat.Models;

namespace WebChat.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppUserDBContext _AppUserDBContext;
        private readonly MessageModelDBContext _MessageModelDBContext;

        public HomeController(AppUserDBContext userContext, MessageModelDBContext messageContext)
        {
            if(messageContext == null)
            {
                Debug.WriteLine("ITS FKING null");
            } else Debug.WriteLine("ITS NOT");
            this._AppUserDBContext = userContext;
            this._MessageModelDBContext = messageContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _AppUserDBContext.userList.ToListAsync());
        }
        
        public async Task<IActionResult> _PersistantMessagesPartial()
        {
            return PartialView(await _MessageModelDBContext.messageList.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
