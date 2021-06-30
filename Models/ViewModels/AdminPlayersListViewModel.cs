using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football_manager.Models;

namespace Football_manager.Models.ViewModels
{
    public class AdminPlayersListViewModel
    {
        public Player Player { get; set; }
        public IEnumerable<Team> Teams { get; set; }
    }
}
