using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class PegiLabel
    {
        public PegiLabel()
        {
            PegiLabelVideogames = new HashSet<PegiLabelVideogame>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<PegiLabelVideogame> PegiLabelVideogames { get; set; }
    }
}
