using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmet_3.Domain.Models
{
    public class Team
    {
        public required string Name { get; set; } = string.Empty;

        public required string Color { get; set; } = string.Empty;

        public required int  Id { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            var other = obj as Team;
            return this.Name == other.Name && this.Id == other.Id;
        }
    }
}
