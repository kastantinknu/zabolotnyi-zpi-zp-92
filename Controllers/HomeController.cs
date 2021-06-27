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
    public class HomeController : Controller
    {

        //public string Index()
        //{
        //    return "Hello World";
        //}
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        // private MyDBContext myDbContext;
       private FootballManagerDBContext myDbContext1;
        //private IPlayerRepository repository;
        //public HomeController(MyDBContext context)
        //{
        //    myDbContext = context;
        //}

        public HomeController(FootballManagerDBContext context)
        {
            myDbContext1 = context;
        }
        //public HomeController(IPlayerRepository repo)
        //{
        //    repository = repo;
        //}

        //public IActionResult Index()
        //{
        //    return View("MyView");
        //}
        //public ViewResult Index()
        //{
        //    //int hour = DateTime.Now.Hour;"MyView"
        //    //ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
        //    return View();
        //}
        //[HttpGet]
        //public ViewResult PlayerForm()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ViewResult PlayerForm(Player player)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Repository.AddPlayers(player);
        //    return View("Added", player);
        //    }
        //    else
        //    {
        //        // Обнаружена ошибка проверки достоверности,
        //        return View();
        //        }
        //}
        public IActionResult Privacy()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
       // public IQueryable<Player> Players => this.myDbContext1.Players;

        public IActionResult Index()
        {
            //return View(this.myDbContext.phones.ToList());
            return View(this.myDbContext1.Players.ToList());

        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        //public ViewResult ListPlayers()//r => r.WillAttend = true
        //{
        //    return View(Repository.Players.Where(p => p.RedCard == false));
        //}
    }
}
