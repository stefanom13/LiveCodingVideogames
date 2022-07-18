using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class Review
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Message { get; set; } = null!;
        public byte Rating { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long PlayerId { get; set; }
        public long VideogameId { get; set; }

        public virtual Player Player { get; set; } = null!;
        public virtual Videogame Videogame { get; set; } = null!;
    }
}
