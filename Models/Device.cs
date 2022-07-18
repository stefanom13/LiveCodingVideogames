using System;
using System.Collections.Generic;

namespace LivecodingVideogames.Models
{
    public partial class Device
    {
        public Device()
        {
            DeviceVideogames = new HashSet<DeviceVideogame>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<DeviceVideogame> DeviceVideogames { get; set; }
    }
}
