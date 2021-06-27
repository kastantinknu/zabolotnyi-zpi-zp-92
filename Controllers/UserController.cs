using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Football_manager.Models;

namespace Football_manager.Controllers
{

    public class UserController : Controller
    {
        private MyDBContext myDbContext;

        public UserController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        //public IList<User> Get()
        //{
        //    return (this.myDbContext.Users.ToList());
        //}

        //public IList<Phone> Get()
        //{
        //    return (this.myDbContext.phones.ToList());
        //}

        //public IActionResult Index()
        //{
        //    return View(this.myDbContext.phones.ToList());
        //}
        public IActionResult List()
        {
            return View(this.myDbContext.phones.ToList());
        }
    }
}
