using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football_manager.Models
{
    public static class Repository
    {
        private static List<Player> players = new List<Player>();
        public static IEnumerable<Player> Players 
        {  
            get {return players; }
        }
        public static void AddPlayers(Player player)
        {
            players.Add(player);
        }
    }
}
