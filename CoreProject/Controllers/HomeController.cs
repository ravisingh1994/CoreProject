using CoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.data = new List<String>()
            {
                "Ravi",
                "Delhi",
                "Btech",
                ".net Programmer"
            };

            ViewData["Chetu"] = new List<String>()
            {
                "Prakash",
                 "Btech",
                 "Shipra SunCity"
            };

            TempData["City"] = new List<String>()
            {
                "Lucknow",
                  "kanpur",
                  "Delhi",
                  "Pune",
                  "Mumbai"
            };
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
