using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football_manager.Models
{
    public class EFPlayerRepository : IPlayerRepository
    {
        private FootballManagerDBContext context;
        public EFPlayerRepository(FootballManagerDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Player> Players => context.Players;
        public IQueryable<Team> Teams => context.Teams;
        public IQueryable<Game> Games => context.Games;

        public void SavePlayer(Player player)
        {
            if (player.Id == 0)
            {
                context.Players.Add(player);
            }
            else
            {
                Player dbEntry = context.Players
                .FirstOrDefault(p => p.Id == player.Id);
                if(dbEntry != null)
                {
                    dbEntry.Name = player.Name;
                    dbEntry.Position = player.Position;
                    dbEntry.RedCard = player.RedCard;
                    dbEntry.TeamId = player.TeamId;
                    dbEntry.Id = player.Id;
                }
            }
context.SaveChanges();
                }
    }
}
