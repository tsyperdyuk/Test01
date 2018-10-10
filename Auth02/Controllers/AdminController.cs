using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Auth02.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var temp = new Dictionary<string, object>
            {
                { "AAAAAA", "AAAAAAA" }
            };
            return View(temp);
        }
    }
}