using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UiFIS_Prototype
{
    public partial class ECardContext : DbContext
    {
        public ECardContext()
        {
        }

        public ECardContext(DbContextOptions<ECardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BloodGroup> BloodGroups { get; set; } = null!;
        public virtual DbSet<Emc> Emcs { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Passport> Passports { get; set; } = null!;
        public virtual DbSet<PatientRecord> PatientRecords { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Place> Places { get; set; } = null!;
        public virtual DbSet<Record> Records { get; set; } = null!;
        public virtual DbSet<Side> Sides { get; set; } = null!;
        public virtual DbSet<TypeOfDiagnosis> TypeOfDiagnoses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ECard;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.ToTable("BloodGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Groups).HasMaxLength(1);
            });

            modelBuilder.Entity<Emc>(entity =>
            {
                entity.ToTable("EMC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Registration).HasColumnType("date");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany(p => p.Emcs)
                    .HasForeignKey(d => d.Patient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMC__Patient__3B75D760");

                entity.HasOne(d => d.PlaceNavigation)
                    .WithMany(p => p.Emcs)
                    .HasForeignKey(d => d.Place)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMC__Place__3C69FB99");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gender1)
                    .HasMaxLength(10)
                    .HasColumnName("Gender");
            });

            modelBuilder.Entity<Passport>(entity =>
            {
                entity.ToTable("Passport");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfIssue).HasColumnType("date");

                entity.Property(e => e.Division).HasMaxLength(65);
            });

            modelBuilder.Entity<PatientRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany(p => p.PatientRecords)
                    .HasForeignKey(d => d.Patient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PatientRe__Patie__3F466844");

                entity.HasOne(d => d.RecordNavigation)
                    .WithMany(p => p.PatientRecords)
                    .HasForeignKey(d => d.Record)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PatientRe__Recor__403A8C7D");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.HasIndex(e => e.Logins, "UQ__Person__D00D0632114937BB")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress).HasMaxLength(20);

                entity.Property(e => e.BirthdayDate).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.Logins)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Passwords)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(12);

                entity.Property(e => e.Polices).HasMaxLength(12);

                entity.Property(e => e.SecondName).HasMaxLength(20);

                entity.HasOne(d => d.BloodNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.Blood)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Person__Blood__2F10007B");

                entity.HasOne(d => d.GenderNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.Gender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Person__Gender__2D27B809");

                entity.HasOne(d => d.PassportNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.Passport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Person__Passport__2E1BDC42");

                entity.HasOne(d => d.SideNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.Side)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Person__Side__300424B4");
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.ToTable("Place");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress).HasMaxLength(255);
            });

            modelBuilder.Entity<Record>(entity =>
            {
                entity.ToTable("Record");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Medicament).HasMaxLength(255);

                entity.Property(e => e.Procedures).HasMaxLength(255);

                entity.Property(e => e.RecordTime).HasColumnType("datetime");

                entity.Property(e => e.Symptom).HasMaxLength(255);

                entity.HasOne(d => d.DoctorNavigation)
                    .WithMany(p => p.RecordDoctorNavigations)
                    .HasForeignKey(d => d.Doctor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Record__Doctor__35BCFE0A");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany(p => p.RecordPatientNavigations)
                    .HasForeignKey(d => d.Patient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Record__Patient__36B12243");

                entity.HasOne(d => d.TypeOfDiagnosisNavigation)
                    .WithMany(p => p.Records)
                    .HasForeignKey(d => d.TypeOfDiagnosis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Record__TypeOfDi__34C8D9D1");
            });

            modelBuilder.Entity<Side>(entity =>
            {
                entity.ToTable("Side");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Side1).HasColumnName("Side");

                entity.Property(e => e.Title).HasMaxLength(20);
            });

            modelBuilder.Entity<TypeOfDiagnosis>(entity =>
            {
                entity.ToTable("TypeOfDiagnosis");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TypeOfDiagnosis1)
                    .HasMaxLength(20)
                    .HasColumnName("TypeOfDiagnosis");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
