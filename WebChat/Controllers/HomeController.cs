﻿using System;
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

        public HomeController(AppUserDBContext userContext)
        {
            this._AppUserDBContext = userContext;
        }

        public async Task<IActionResult> Index()
        {
            Debug.WriteLine("debug1");
            return View(await _AppUserDBContext.userList.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
