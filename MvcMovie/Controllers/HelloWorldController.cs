using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numtimes = 8)
        {
            ViewData["message"] = "Hello " + name;
            ViewData["NumTimes"] = numtimes;

            return View();
        }

    }
}
