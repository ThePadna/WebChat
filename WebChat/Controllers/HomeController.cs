using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebChat.Areas.Identity.Data;
using WebChat.DAL;
using WebChat.Models;

namespace WebChat.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppUserDBContext _WebChatDBContext;
        public HomeController(AppUserDBContext context)
        {
            this._WebChatDBContext = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _WebChatDBContext.userList.ToListAsync());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
