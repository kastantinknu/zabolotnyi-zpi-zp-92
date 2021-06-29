using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football_manager.Models;

namespace Football_manager.Models
{
    public interface IPlayerRepository
    {
        IQueryable<Player> Players { get; }
        IQueryable<Team> Teams { get; }
        IQueryable<Game> Games { get; }
        void SavePlayer(Player player);
    }
}
