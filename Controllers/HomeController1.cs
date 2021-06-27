using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Football_manager.Models;

namespace Football_manager.Controllers
{
    public class HomeController1 : Controller
    {
        private MyDBContext myDbContext;

        public HomeController1(MyDBContext context)
        {
            myDbContext = context;
        }

        public IActionResult Index()
        {
            return View(this.myDbContext.phones.ToList());
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
