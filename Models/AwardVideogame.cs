using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class AwardVideogame
    {
        public long Id { get; set; }
        public short Year { get; set; }
        public long AwardId { get; set; }
        public long VideogameId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Award Award { get; set; } = null!;
        public virtual Videogame Videogame { get; set; } = null!;
    }
}
