using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.DBContexts;
using WebApplication5.Models;

namespace WebApplication5.Controllers
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

        public IList<Phone> Get()
        {
            return (this.myDbContext.phones.ToList());
        }


    }
}
