using System;
using System.Collections.Generic;

#nullable disable

namespace WaterBuffalo.Models
{
    public partial class Location
    {
        public Location()
        {
            Burials = new HashSet<Burial>();
        }

        public int LocationId { get; set; }
        public string LocationString { get; set; }
        public string BurialLocationNs { get; set; }
        public string BurialLocationEw { get; set; }
        public int? LowPairNs { get; set; }
        public int? HighPairNs { get; set; }
        public int? LowPairEw { get; set; }
        public int? HighPairEw { get; set; }
        public string BurialSubplot { get; set; }
        public int? AreaNum { get; set; }
        public int? TombNumber { get; set; }

        public virtual ICollection<Burial> Burials { get; set; }
    }
}
