﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth02.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            var temp = new Dictionary<string, object>
            {
                { "Placeholder", "Placeholder" }
            };
            return View(temp);
        }
    }
}
