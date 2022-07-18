using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class Player
    {
        public Player()
        {
            PlayerTournaments = new HashSet<PlayerTournament>();
            Reviews = new HashSet<Review>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public string City { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<PlayerTournament> PlayerTournaments { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
