using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football_manager.Models
{
    public class Game
    {
        public byte Id { get; set; }
        public DateTime Data { get; set; }
        public byte FirstTeamId { get; set; }
        public byte SecondTeamId { get; set; }
        public string Score { get; set; }

    }
}
