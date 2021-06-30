using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Football_manager.Models;
using Football_manager.Models.ViewModels;

namespace Football_manager.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerRepository repository;
        public int PageSize = 3;
        public PlayerController(IPlayerRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string team, int Page = 1)
            //=> View(repository.Players.ToList<Player>()
            //            .OrderBy(p => p.Id)
            //            .Skip((PlayerPage - 1) * PageSize)
            //            .Take(PageSize));

            => View(new PlayersListViewModel
            {
                Teams = repository.Teams.ToList<Team>(),
                Players = repository.Players.ToList<Player>()
               .Where(p => team == null || p.TeamId.ToString() == team)
               .OrderBy(p => p.Id)
               .Skip((Page - 1) * PageSize)
               .Take(PageSize),
                Paginginfo = new Paginginfo
                {
                    CurrentPage = Page,
                    ItemsPerPage = PageSize,
                    // TotalItems = repository.Players.Count()
                    TotalItems = team == null ?
                        repository.Players.Count() :
                        repository.Players.Where(e =>
                        e.TeamId.ToString() == team).Count()
                },
                CurrentTeam = team
                
          // CurrentTeamName = team == null ?" ": repository.Teams.Where(e => e.Id.ToString()== team).First<Team>().Name
                //team  
            });
        //// GET: PlayerController
        //public ActionResult Index().ToList<Player>()
        //{
        //    return View();
        //}

        //// GET: PlayerController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}repository.Players

        //// GET: PlayerController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: PlayerController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: PlayerController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: PlayerController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: PlayerController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: PlayerController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
