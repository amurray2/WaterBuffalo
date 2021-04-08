using System;
using System.Collections.Generic;

#nullable disable

namespace WaterBuffalo.Models
{
    public partial class Bone
    {
        public int BoneInfoId { get; set; }
        public int BurialId { get; set; }
        public DateTime? DateOnSkull { get; set; }
        public string BasilarSuture { get; set; }
        public int? VentralArc { get; set; }
        public int? SubpubicAngle { get; set; }
        public int? SciaticNotch { get; set; }
        public int? PubicBone { get; set; }
        public int? PreaurSulcus { get; set; }
        public int? MedialIpRamus { get; set; }
        public int? DorsalPitting { get; set; }
        public string ForemanMagnum { get; set; }
        public decimal? FemurHead { get; set; }
        public decimal? HumerusHead { get; set; }
        public string Osteophytosis { get; set; }
        public string PubicSymphysis { get; set; }
        public decimal? FemurLength { get; set; }
        public decimal? HumerusLength { get; set; }
        public decimal? TibiaLength { get; set; }
        public int? Robust { get; set; }
        public int? SupraorbitalRidges { get; set; }
        public int? OrbitEdge { get; set; }
        public int? ParietalBossing { get; set; }
        public int? Gonian { get; set; }
        public int? NuchalCrest { get; set; }
        public int? ZygomaticCrest { get; set; }
        public string CranialSuture { get; set; }
        public decimal? MaximumCranialLength { get; set; }
        public decimal? MaximumCranialBreadth { get; set; }
        public decimal? BasionBregmaHeight { get; set; }
        public decimal? BasionNasion { get; set; }
        public decimal? BasionProsthionLength { get; set; }
        public decimal? BizygomaticDiameter { get; set; }
        public decimal? NasionProsthion { get; set; }
        public decimal? MaximumNasalBreadth { get; set; }
        public decimal? InterorbitalBreadth { get; set; }
        public string EpiphysealUnion { get; set; }
        public bool? SkullAtMagazine { get; set; }
        public bool? PostrcraniaAtMagazine { get; set; }
        public string SexSkull { get; set; }
        public string AgeSkull { get; set; }
        public string Rack { get; set; }
        public int? ShelfNumber { get; set; }
        public bool? ToBeConfirmed { get; set; }
        public bool? SkullTrauma { get; set; }
        public bool? PoscraniaTrauma { get; set; }
        public bool? CribraOrbitala { get; set; }
        public bool? PoroticHyperostosis { get; set; }
        public string PoroticHyperososisLocations { get; set; }
        public bool? MetopicSuture { get; set; }
        public bool? ButtonOsteoma { get; set; }
        public string OsteologyUnknownComment { get; set; }
        public bool? TemporalMandibularJointOsteoarthritus { get; set; }
        public bool? LinearHypoplasiaEnamel { get; set; }
        public string OsteologyNotes { get; set; }

        public virtual Burial Burial { get; set; }
    }
}
