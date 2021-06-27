using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football_manager.Models;
using Microsoft.AspNetCore.Mvc;

namespace Football_manager.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IPlayerRepository repository;
        public NavigationMenuViewComponent(IPlayerRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Players
            .Select(x => x.TeamId)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
