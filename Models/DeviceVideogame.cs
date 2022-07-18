using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class DeviceVideogame
    {
        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long DeviceId { get; set; }
        public long VideogameId { get; set; }

        public virtual Device Device { get; set; } = null!;
        public virtual Videogame Videogame { get; set; } = null!;
    }
}
