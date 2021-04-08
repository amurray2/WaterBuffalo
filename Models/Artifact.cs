using System;
using System.Collections.Generic;

#nullable disable

namespace WaterBuffalo.Models
{
    public partial class Artifact
    {
        public int ArtifactId { get; set; }
        public int BurialId { get; set; }
        public string ArtifactDescription { get; set; }

        public virtual Burial Burial { get; set; }
    }
}
