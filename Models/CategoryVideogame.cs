using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class CategoryVideogame
    {
        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long CategoryId { get; set; }
        public long VideogameId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Videogame Videogame { get; set; } = null!;
    }
}
