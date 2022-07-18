using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class Tournament
    {
        public Tournament()
        {
            PlayerTournaments = new HashSet<PlayerTournament>();
            TournamentVideogames = new HashSet<TournamentVideogame>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        public short Year { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<PlayerTournament> PlayerTournaments { get; set; }
        public virtual ICollection<TournamentVideogame> TournamentVideogames { get; set; }
    }
}
