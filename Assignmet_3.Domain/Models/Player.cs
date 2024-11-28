using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmet_3.Domain.Models
{
    public class Player
    {
        public required int Id { get; set; }
        public required int Age { get; set; }
        public required decimal AveragePoints { get; set; }
        
        public required string Image { get; set; }

        public required string Name { get; set; }

        public required decimal Height { get; set; }

        public required decimal FoulsPerGame { get; set; }

        public required Team Team { get; set; }
    }
}
