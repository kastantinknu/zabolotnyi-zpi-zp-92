using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football_manager.Models.ViewModels
{
    public class GameListViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public Paginginfo Paginginfo { get; set; }
        public string CurrentTeam { get; set; }
        //Game  public string CurrentTeamName { get; set; }
    }
}
