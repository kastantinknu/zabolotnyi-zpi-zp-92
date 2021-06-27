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
    }
}
