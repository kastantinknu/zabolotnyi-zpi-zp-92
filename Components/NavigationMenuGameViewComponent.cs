using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football_manager.Models;
using Microsoft.AspNetCore.Mvc;

namespace Football_manager.Components
{
    public class NavigationMenuGameViewComponent : ViewComponent
    {
        private IPlayerRepository repository;
        public NavigationMenuGameViewComponent(IPlayerRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["firstteam"];

            //var people = from user in repository.Games
            //             from phone in repository.Teams
            //             select new { user => user.Id == phone.TeamId };

            //var items = from g in repository.Games
            //            select new
            //            {
            //                id = g.Name,
            //                DateOfBirth = DateTime.Now.Year - u.Age
            //            };
            //var items1 = repository.Games
            //    .Select(x => x.FirstTeamId)
            //    .Distinct();


            //Model.Teams.ToList().Find(x => x.Id == p.TeamId).Name;

            return View(repository.Teams
                
//                Games
//.Select(x => x.FirstTeamId)
//            .Distinct()
           );


            //View(repository.Players            .OrderBy(x => x) 
            //.Select(x => x.TeamId)
            //.Distinct()
            //.OrderBy(x => x));
        }
    }
}
