using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class SoftwareHouse
    {
        public SoftwareHouse()
        {
            Videogames = new HashSet<Videogame>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string TaxId { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Videogame> Videogames { get; set; }
    }
}
