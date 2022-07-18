using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class TournamentVideogame
    {
        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long TournamentId { get; set; }
        public long VideogameId { get; set; }

        public virtual Tournament Tournament { get; set; } = null!;
        public virtual Videogame Videogame { get; set; } = null!;
    }
}
