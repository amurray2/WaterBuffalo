using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WaterBuffalo.Models
{
    public partial class FagElGamousContext : DbContext
    {
        public FagElGamousContext()
        {
        }

        public FagElGamousContext(DbContextOptions<FagElGamousContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artifact> Artifacts { get; set; }
        public virtual DbSet<BiologicalSample> BiologicalSamples { get; set; }
        public virtual DbSet<Bone> Bones { get; set; }
        public virtual DbSet<Burial> Burials { get; set; }
        public virtual DbSet<C14Sample> C14Samples { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Preservation> Preservations { get; set; }
        public virtual DbSet<Researcher> Researchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-14AH40MQ\\SQLExpress;Database=FagElGamous;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Artifact>(entity =>
            {
                entity.Property(e => e.ArtifactId)
                    .ValueGeneratedNever()
                    .HasColumnName("artifact_id");

                entity.Property(e => e.ArtifactDescription)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("artifact_description");

                entity.Property(e => e.BurialId).HasColumnName("burial_id");

                entity.HasOne(d => d.Burial)
                    .WithMany(p => p.Artifacts)
                    .HasForeignKey(d => d.BurialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Artifacts__buria__4E88ABD4");
            });

            modelBuilder.Entity<BiologicalSample>(entity =>
            {
                entity.HasKey(e => e.BioSampleId)
                    .HasName("PK__Biologic__2F14FA9347D60F46");

                entity.ToTable("Biological Sample");

                entity.Property(e => e.BioSampleId)
                    .ValueGeneratedNever()
                    .HasColumnName("bio_sample_id");

                entity.Property(e => e.BagNum).HasColumnName("bag_num");

                entity.Property(e => e.BurialId).HasColumnName("burial_id");

                entity.Property(e => e.Initials)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("initials");

                entity.Property(e => e.Notes)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.PreviouslySampled).HasColumnName("previously_sampled");

                entity.Property(e => e.RackNum).HasColumnName("rack_num");

                entity.HasOne(d => d.Burial)
                    .WithMany(p => p.BiologicalSamples)
                    .HasForeignKey(d => d.BurialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Biologica__buria__5535A963");
            });

            modelBuilder.Entity<Bone>(entity =>
            {
                entity.HasKey(e => e.BoneInfoId)
                    .HasName("PK__Bones__E22A264B364F3145");

                entity.HasIndex(e => e.BurialId, "UQ__Bones__12A901C438E97131")
                    .IsUnique();

                entity.Property(e => e.BoneInfoId)
                    .ValueGeneratedNever()
                    .HasColumnName("bone_info_id");

                entity.Property(e => e.AgeSkull)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("age_skull");

                entity.Property(e => e.BasilarSuture)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("basilar_suture");

                entity.Property(e => e.BasionBregmaHeight)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BizygomaticDiameter)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BurialId).HasColumnName("burial_id");

                entity.Property(e => e.ButtonOsteoma).HasColumnName("button_osteoma");

                entity.Property(e => e.CranialSuture)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cranial_suture");

                entity.Property(e => e.CribraOrbitala).HasColumnName("cribra_orbitala");

                entity.Property(e => e.DateOnSkull)
                    .HasColumnType("datetime")
                    .HasColumnName("date_on_skull");

                entity.Property(e => e.DorsalPitting).HasColumnName("dorsal_pitting");

                entity.Property(e => e.EpiphysealUnion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("epiphyseal_union");

                entity.Property(e => e.FemurHead)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("femur_head");

                entity.Property(e => e.FemurLength)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("femur_length");

                entity.Property(e => e.ForemanMagnum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("foreman_magnum");

                entity.Property(e => e.Gonian).HasColumnName("gonian");

                entity.Property(e => e.HumerusHead)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("humerus_head");

                entity.Property(e => e.HumerusLength)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("humerus_length");

                entity.Property(e => e.InterorbitalBreadth)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("interorbital_breadth");

                entity.Property(e => e.LinearHypoplasiaEnamel).HasColumnName("linear_hypoplasia_enamel");

                entity.Property(e => e.MaximumCranialBreadth)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("maximum_cranial_breadth");

                entity.Property(e => e.MaximumCranialLength)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("maximum_cranial_length");

                entity.Property(e => e.MaximumNasalBreadth)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("maximum_nasal_breadth");

                entity.Property(e => e.MedialIpRamus).HasColumnName("medial_IP_ramus");

                entity.Property(e => e.MetopicSuture).HasColumnName("metopic_suture");

                entity.Property(e => e.NasionProsthion)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("nasion_prosthion");

                entity.Property(e => e.NuchalCrest).HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge).HasColumnName("orbit_edge");

                entity.Property(e => e.OsteologyNotes)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("osteology_notes");

                entity.Property(e => e.OsteologyUnknownComment)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("osteology_unknown_comment");

                entity.Property(e => e.Osteophytosis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("osteophytosis");

                entity.Property(e => e.ParietalBossing).HasColumnName("parietal_bossing");

                entity.Property(e => e.PoroticHyperososisLocations)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("porotic_hyperososis_locations");

                entity.Property(e => e.PoroticHyperostosis).HasColumnName("porotic_hyperostosis");

                entity.Property(e => e.PoscraniaTrauma).HasColumnName("poscrania_trauma");

                entity.Property(e => e.PostrcraniaAtMagazine).HasColumnName("postrcrania_at_magazine");

                entity.Property(e => e.PreaurSulcus).HasColumnName("preaur_sulcus");

                entity.Property(e => e.PubicBone).HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSymphysis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pubic_symphysis");

                entity.Property(e => e.Rack)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("rack");

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.SciaticNotch).HasColumnName("sciatic_notch");

                entity.Property(e => e.SexSkull)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex_skull");

                entity.Property(e => e.ShelfNumber).HasColumnName("shelf_number");

                entity.Property(e => e.SkullAtMagazine).HasColumnName("skull_at_magazine");

                entity.Property(e => e.SkullTrauma).HasColumnName("skull_trauma");

                entity.Property(e => e.SubpubicAngle).HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges).HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TemporalMandibularJointOsteoarthritus).HasColumnName("temporal_mandibular_joint_osteoarthritus");

                entity.Property(e => e.TibiaLength)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("tibia_length");

                entity.Property(e => e.ToBeConfirmed).HasColumnName("to_be_confirmed");

                entity.Property(e => e.VentralArc).HasColumnName("ventral_arc");

                entity.Property(e => e.ZygomaticCrest).HasColumnName("zygomatic_crest");

                entity.HasOne(d => d.Burial)
                    .WithOne(p => p.Bone)
                    .HasForeignKey<Bone>(d => d.BurialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bones__burial_id__52593CB8");
            });

            modelBuilder.Entity<Burial>(entity =>
            {
                entity.ToTable("Burial");

                entity.Property(e => e.BurialId)
                    .ValueGeneratedNever()
                    .HasColumnName("burial_id");

                entity.Property(e => e.AgeCodeSingle)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("age_code_single");

                entity.Property(e => e.AgeMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("age_method");

                entity.Property(e => e.ArtifactFound).HasColumnName("artifact_found");

                entity.Property(e => e.BodyAnalysisYear)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("body_analysis_year");

                entity.Property(e => e.BoneTaken).HasColumnName("bone_taken");

                entity.Property(e => e.BurialAdultChild)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("burial_adult_child");

                entity.Property(e => e.BurialDepth).HasColumnName("burial_depth");

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialSituation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("burial_situation");

                entity.Property(e => e.ByuSample)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("byu_sample");

                entity.Property(e => e.DayFound)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("day_found");

                entity.Property(e => e.DescriptionOfTaken)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("description_of_taken");

                entity.Property(e => e.EstimateAge).HasColumnName("estimate_age");

                entity.Property(e => e.EstimateLivingStature)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("estimate_living_stature");

                entity.Property(e => e.FieldBook)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("field_book");

                entity.Property(e => e.FieldBookPageNumber).HasColumnName("field_book_page_number");

                entity.Property(e => e.FieldNotes)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("field_notes");

                entity.Property(e => e.GeFunctionTotal).HasColumnName("GE_function_total");

                entity.Property(e => e.GenderGe).HasColumnName("gender_GE");

                entity.Property(e => e.HairColor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hair_color");

                entity.Property(e => e.HairTaken).HasColumnName("hair_taken");

                entity.Property(e => e.HeadDirection)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("head_direction");

                entity.Property(e => e.InitialsOfDataEntryChecker)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("initials_of_data_entry_checker");

                entity.Property(e => e.InitialsOfDataEntryExpert)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("initials_of_data_entry_expert");

                entity.Property(e => e.IsTomb).HasColumnName("is_tomb");

                entity.Property(e => e.LengthOfRemains).HasColumnName("length_of_remains");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MonthExcav)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("month_excav");

                entity.Property(e => e.MonthFound)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("month_found");

                entity.Property(e => e.PathologyAnomalies)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pathology_anomalies");

                entity.Property(e => e.SampleNum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sample_num");

                entity.Property(e => e.SampleTaken)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sample_taken");

                entity.Property(e => e.SexMethod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sex_method");

                entity.Property(e => e.SoftTissueTaken).HasColumnName("soft_tissue_taken");

                entity.Property(e => e.SouthToFeet).HasColumnName("south_to_feet");

                entity.Property(e => e.SouthToHead).HasColumnName("south_to_head");

                entity.Property(e => e.TextileTaken).HasColumnName("textile_taken");

                entity.Property(e => e.TombDescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("tomb_description");

                entity.Property(e => e.ToothAttrition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tooth_attrition");

                entity.Property(e => e.ToothEruption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tooth_eruption");

                entity.Property(e => e.ToothTaken).HasColumnName("tooth_taken");

                entity.Property(e => e.WestToFeet).HasColumnName("west_to_feet");

                entity.Property(e => e.WestToHead).HasColumnName("west_to_head");

                entity.Property(e => e.YearExcav)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("year_excav");

                entity.Property(e => e.YearFound)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("year_found");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Burials)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Burial__location__4BAC3F29");
            });

            modelBuilder.Entity<C14Sample>(entity =>
            {
                entity.ToTable("C14 Sample");

                entity.Property(e => e.C14SampleId)
                    .ValueGeneratedNever()
                    .HasColumnName("c14_sample_id");

                entity.Property(e => e.AreaNum).HasColumnName("area_num");

                entity.Property(e => e.BurialId).HasColumnName("burial_id");

                entity.Property(e => e.Calibrated95CalendarDateAvg).HasColumnName("calibrated_95%_calendar_date_AVG");

                entity.Property(e => e.Calibrated95CalendarDateMax).HasColumnName("calibrated_95%_calendar_date_MAX");

                entity.Property(e => e.Calibrated95CalendarDateMin).HasColumnName("calibrated_95%_calendar_date_MIN");

                entity.Property(e => e.Calibrated95CalendarDateSpan).HasColumnName("calibrated_95%_calendar_date_SPAN");

                entity.Property(e => e.Category)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.Conventia14cAgeBp).HasColumnName("conventia_14C-age_BP");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Foci).HasColumnName("foci");

                entity.Property(e => e.Location)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Notes)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.Questions)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("questions");

                entity.Property(e => e.RackNum).HasColumnName("rack_num");

                entity.Property(e => e.SizeMl).HasColumnName("size_ml");

                entity.Property(e => e.TubeNum).HasColumnName("tube_num");

                entity.Property(e => e._14cCalendarDate).HasColumnName("14C_calendar_date");

                entity.HasOne(d => d.Burial)
                    .WithMany(p => p.C14Samples)
                    .HasForeignKey(d => d.BurialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__C14 Sampl__buria__5812160E");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("location_id");

                entity.Property(e => e.AreaNum).HasColumnName("area_num");

                entity.Property(e => e.BurialLocationEw)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("burial_location_EW");

                entity.Property(e => e.BurialLocationNs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("burial_location_NS");

                entity.Property(e => e.BurialSubplot)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("burial_subplot");

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.LocationString)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location_string");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.TombNumber).HasColumnName("tomb_number");
            });

            modelBuilder.Entity<Preservation>(entity =>
            {
                entity.HasKey(e => e.BurialId)
                    .HasName("PK__Preserva__12A901C5A6A9F304");

                entity.ToTable("Preservation");

                entity.Property(e => e.BurialId)
                    .ValueGeneratedNever()
                    .HasColumnName("burial_id");

                entity.Property(e => e.BurialIcon)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("burial_icon");

                entity.Property(e => e.BurialIcon2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("burial_icon_2");

                entity.Property(e => e.BurialWrapping)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("burial_wrapping");

                entity.Property(e => e.PreservationDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("preservation_description");

                entity.Property(e => e.PreservationIndex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("preservation_index");

                entity.HasOne(d => d.Burial)
                    .WithOne(p => p.Preservation)
                    .HasForeignKey<Preservation>(d => d.BurialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Preservat__buria__5AEE82B9");
            });

            modelBuilder.Entity<Researcher>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Research__B9BE370F3F2BF223");

                entity.ToTable("Researcher");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.IsSuperUser).HasColumnName("is_super_user");

                entity.Property(e => e.LastName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
