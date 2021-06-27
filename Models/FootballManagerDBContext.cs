using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Football_manager.Models
{
    public class FootballManagerDBContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public FootballManagerDBContext(DbContextOptions<FootballManagerDBContext> options) : base(options)
        {
        }
    }
}
