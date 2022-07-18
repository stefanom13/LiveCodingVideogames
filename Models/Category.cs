using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryVideogames = new HashSet<CategoryVideogame>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<CategoryVideogame> CategoryVideogames { get; set; }
    }
}
