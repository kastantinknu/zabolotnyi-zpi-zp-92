﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football_manager.Models;

namespace Football_manager.Models.ViewModels
{
    public class PlayersListViewModel
    {
        public IEnumerable<Player> Players { get; set; }
        public Paginginfo Paginginfo { get; set; }
    }
}
