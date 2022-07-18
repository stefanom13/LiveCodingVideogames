using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class Videogame
    {
        public Videogame()
        {
            AwardVideogames = new HashSet<AwardVideogame>();
            CategoryVideogames = new HashSet<CategoryVideogame>();
            DeviceVideogames = new HashSet<DeviceVideogame>();
            PegiLabelVideogames = new HashSet<PegiLabelVideogame>();
            Reviews = new HashSet<Review>();
            TournamentVideogames = new HashSet<TournamentVideogame>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Overview { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long SoftwareHouseId { get; set; }

        public virtual SoftwareHouse SoftwareHouse { get; set; } = null!;
        public virtual ICollection<AwardVideogame> AwardVideogames { get; set; }
        public virtual ICollection<CategoryVideogame> CategoryVideogames { get; set; }
        public virtual ICollection<DeviceVideogame> DeviceVideogames { get; set; }
        public virtual ICollection<PegiLabelVideogame> PegiLabelVideogames { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<TournamentVideogame> TournamentVideogames { get; set; }
    }
}
