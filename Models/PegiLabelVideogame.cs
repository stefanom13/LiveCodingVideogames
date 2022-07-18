using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class PegiLabelVideogame
    {
        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long PegiLabelId { get; set; }
        public long VideogameId { get; set; }

        public virtual PegiLabel PegiLabel { get; set; } = null!;
        public virtual Videogame Videogame { get; set; } = null!;
    }
}
