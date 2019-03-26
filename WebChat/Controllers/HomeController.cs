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
        private readonly AppUserDBContext _appUserDBContext;
        private readonly MessageModelDBContext _messageModelDBContext;

        public HomeController(MessageModelDBContext messageModelDBContext, AppUserDBContext appUserDBContext)
        {
            this._messageModelDBContext = messageModelDBContext;
            this._appUserDBContext = appUserDBContext;
        }

        public ActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel(this._appUserDBContext.userList, this._messageModelDBContext.messageList);
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
