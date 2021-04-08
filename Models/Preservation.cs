using System;
using System.Collections.Generic;

#nullable disable

namespace WaterBuffalo.Models
{
    public partial class Preservation
    {
        public int BurialId { get; set; }
        public string PreservationDescription { get; set; }
        public string BurialIcon { get; set; }
        public string BurialIcon2 { get; set; }
        public string PreservationIndex { get; set; }
        public string BurialWrapping { get; set; }

        public virtual Burial Burial { get; set; }
    }
}
