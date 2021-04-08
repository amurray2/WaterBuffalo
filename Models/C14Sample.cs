﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WaterBuffalo.Models
{
    public partial class C14Sample
    {
        public int C14SampleId { get; set; }
        public int BurialId { get; set; }
        public int? RackNum { get; set; }
        public int? AreaNum { get; set; }
        public int? TubeNum { get; set; }
        public string Description { get; set; }
        public int? SizeMl { get; set; }
        public int? Foci { get; set; }
        public string Location { get; set; }
        public string Questions { get; set; }
        public int? Conventia14cAgeBp { get; set; }
        public int? _14cCalendarDate { get; set; }
        public int? Calibrated95CalendarDateMax { get; set; }
        public int? Calibrated95CalendarDateMin { get; set; }
        public int? Calibrated95CalendarDateSpan { get; set; }
        public int? Calibrated95CalendarDateAvg { get; set; }
        public string Category { get; set; }
        public string Notes { get; set; }

        public virtual Burial Burial { get; set; }
    }
}
