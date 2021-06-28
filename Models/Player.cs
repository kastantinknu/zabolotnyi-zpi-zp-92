using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Football_manager.Models
{
    public class Player
    {
        [Required()]
        public byte Id { get; set; }

        [Required(ErrorMessage = "Please enter player's name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter player's position")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Please specify RedCard")]
       public byte? RedCard { get; set; }
        [Required(ErrorMessage = "Please enter player's team")]
        public byte TeamId { get; set; }



    }
}
