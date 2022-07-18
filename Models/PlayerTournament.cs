using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class PlayerTournament
    {
        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long PlayerId { get; set; }
        public long TournamentId { get; set; }

        public virtual Player Player { get; set; } = null!;
        public virtual Tournament Tournament { get; set; } = null!;
    }
}
