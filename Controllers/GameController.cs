using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football_manager.Models;
using Football_manager.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Football_manager.Controllers
{
    public class GameController : Controller
    {
        private IPlayerRepository repository;
      public int PageSize = 3;
        public GameController(IPlayerRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string firstteam, int Page = 1)
            //=> View(repository.Players.ToList<Player>()
            //            .OrderBy(p => p.Id)
            //            .Skip((PlayerPage - 1) * PageSize)
            //            .Take(PageSize));

            => View(new GameListViewModel
            { 

                Games = repository.Games
                .Where(p => firstteam == null || p.FirstTeamId.ToString() == firstteam || p.SecondTeamId.ToString() == firstteam)
                .OrderBy(p => p.Id)
                .Skip((Page - 1) * PageSize)
                .Take(PageSize),
                Paginginfo = new Paginginfo
                {
                    CurrentPage = Page,
                    ItemsPerPage = PageSize,
                    TotalItems = firstteam == null ? 
                    repository.Games.Count() : 
                    repository.Games.Where(e =>
                    e.FirstTeamId.ToString() == firstteam || e.SecondTeamId.ToString() == firstteam).Count()


                },
                                CurrentTeam = firstteam,

                //    new GameListViewModel.ToList<Game>()
                //{
                //    Games = repository.Games.ToList<Game>(),
                ////    Players = repository.Players.ToList<Player>()
                //// .Where(p => team == null || p.TeamId.ToString() == team)
                ////.OrderBy(p => p.Id)
                ////.Skip((PlayerPage - 1) * PageSize)
                ////.Take(PageSize),
                ////    Paginginfo = new Paginginfo
                ////    {
                ////        CurrentPage = PlayerPage,
                ////        ItemsPerPage = PageSize,
                ////        // TotalItems = repository.Players.Count()
                ////        TotalItems = team == null ?
                ////            repository.Players.Count() :
                ////            repository.Players.Where(e =>
                ////            e.TeamId.ToString() == team).Count()
                ////    },
                //   // CurrentTeam = team

                //    // CurrentTeamName = team == null ?" ": repository.Teams.Where(e => e.Id.ToString()== team).First<Team>().Name
                //    //team  
                //}
            });

    }
}
