using System;
using System.Collections.Generic;

#nullable disable

namespace WaterBuffalo.Models
{
    public partial class BiologicalSample
    {
        public int BioSampleId { get; set; }
        public int BurialId { get; set; }
        public int? RackNum { get; set; }
        public int? BagNum { get; set; }
        public bool? PreviouslySampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }

        public virtual Burial Burial { get; set; }
    }
}
