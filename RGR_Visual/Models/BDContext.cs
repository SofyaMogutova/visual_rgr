using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RGR_Visual.Models
{
    public partial class BDContext : DbContext
    {
        public BDContext()
        {
        }

        public BDContext(DbContextOptions<BDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Horse> Horses { get; set; } = null!;
        public virtual DbSet<Jockey> Jockeys { get; set; } = null!;
        public virtual DbSet<Owner> Owners { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<Trainer> Trainers { get; set; } = null!;
        public virtual DbSet<Run> Runs { get; set; } = null!;
        public virtual DbSet<Racetrack> Racetracks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\Соня\\source\\repos\\RGR_Visual\\RGR_Visual\\rgr.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Horse>(entity =>
            {
                entity.HasKey(e => e.Nickname);

                entity.ToTable("Horse");

                entity.Property(e => e.Nickname).HasColumnType("STRING");
                entity.Property(e => e.Age).HasColumnType("STRING");

                entity.Property(e => e.Gender).HasColumnType("STRING");
                entity.Property(e => e.FIOTrainer).HasColumnType("STRING");
                entity.Property(e => e.FIOOwner).HasColumnType("STRING");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.Horses)
                    .HasForeignKey(d => d.FIOOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TrainerNavigation)
                    .WithMany(p => p.Horses)
                    .HasForeignKey(d => d.FIOTrainer);

            });

            modelBuilder.Entity<Jockey>(entity =>
            {
                entity.HasKey(e => e.FIO);

                entity.ToTable("Jockey");

                entity.Property(e => e.FIO).HasColumnType("STRING");
                entity.Property(e => e.Rank).HasColumnType("STRING");
            });

     

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.HasKey(e => e.FIO);

                entity.ToTable("Owner");

                entity.Property(e => e.FIO).HasColumnType("STRING");
            });

            modelBuilder.Entity<Racetrack>(entity =>
            {
                entity.HasKey(e => e.Title);

                entity.ToTable("Racetrack");

                entity.Property(e => e.Title).HasColumnType("STRING");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasKey(e => new { e.DateRun, e.NumberRun, e.TitleRacetrack });

                entity.ToTable("Result");
                
                entity.Property(e => e.HorseNickname).HasColumnType("STRING");
                
                entity.Property(e => e.FIOJockey).HasColumnType("STRING");
                
                entity.Property(e => e.StartPosition).HasColumnName("StartPosition");

                entity.Property(e => e.FinishPosition).HasColumnName("FinishPosition");

                entity.Property(e => e.Lag).HasColumnType("STRING");

                entity.Property(e => e.DateRun).HasColumnType("STRING");

                entity.Property(e => e.NumberRun).HasColumnName("NumberRun");

                entity.Property(e => e.TitleRacetrack).HasColumnType("STRING");


                entity.HasOne(d => d.HorseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.HorseNickname);

                entity.HasOne(d => d.JockeyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FIOJockey);

                entity.HasOne(d => d.RunNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.DateRun, d.NumberRun, d.TitleRacetrack });

            });

            modelBuilder.Entity<Run>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.Number, e.TitleRacetrack });

                entity.ToTable("Run");

                entity.Property(e => e.Number).HasColumnType("STRING");

                entity.Property(e => e.Date).HasColumnType("STRING");

                entity.Property(e => e.Distance).HasColumnType("STRING");

                entity.Property(e => e.TitleRacetrack).HasColumnType("STRING");


                entity.HasOne(d => d.RacetrackNavigation)
                    .WithMany(p => p.Runs)
                    .HasForeignKey(d => d.TitleRacetrack)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.HasKey(e => e.FIO);

                entity.ToTable("Trainer");


                entity.Property(e => e.FIO).HasColumnType("STRING");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
