using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football_manager.Models.ViewModels
{
    public class EditInfo
    {
        public Player player { get; set; }
        public IEnumerable<Player> Players { get; set; }


    }
}
