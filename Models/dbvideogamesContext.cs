using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LivecodingVideogames.Models
{
    public partial class dbvideogamesContext : DbContext
    {
        public dbvideogamesContext()
        {
        }

        public dbvideogamesContext(DbContextOptions<dbvideogamesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Award> Awards { get; set; } = null!;
        public virtual DbSet<AwardVideogame> AwardVideogames { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<CategoryVideogame> CategoryVideogames { get; set; } = null!;
        public virtual DbSet<Device> Devices { get; set; } = null!;
        public virtual DbSet<DeviceVideogame> DeviceVideogames { get; set; } = null!;
        public virtual DbSet<PegiLabel> PegiLabels { get; set; } = null!;
        public virtual DbSet<PegiLabelVideogame> PegiLabelVideogames { get; set; } = null!;
        public virtual DbSet<Player> Players { get; set; } = null!;
        public virtual DbSet<PlayerTournament> PlayerTournaments { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<SoftwareHouse> SoftwareHouses { get; set; } = null!;
        public virtual DbSet<Tournament> Tournaments { get; set; } = null!;
        public virtual DbSet<TournamentVideogame> TournamentVideogames { get; set; } = null!;
        public virtual DbSet<Videogame> Videogames { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=db-videogames;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Award>(entity =>
            {
                entity.ToTable("awards");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<AwardVideogame>(entity =>
            {
                entity.ToTable("award_videogame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AwardId).HasColumnName("award_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VideogameId).HasColumnName("videogame_id");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Award)
                    .WithMany(p => p.AwardVideogames)
                    .HasForeignKey(d => d.AwardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("award_videogame$award_videogame_award_id_foreign");

                entity.HasOne(d => d.Videogame)
                    .WithMany(p => p.AwardVideogames)
                    .HasForeignKey(d => d.VideogameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("award_videogame$award_videogame_videogame_id_foreign");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CategoryVideogame>(entity =>
            {
                entity.ToTable("category_videogame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VideogameId).HasColumnName("videogame_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryVideogames)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("category_videogame$category_videogame_category_id_foreign");

                entity.HasOne(d => d.Videogame)
                    .WithMany(p => p.CategoryVideogames)
                    .HasForeignKey(d => d.VideogameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("category_videogame$category_videogame_videogame_id_foreign");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("devices");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<DeviceVideogame>(entity =>
            {
                entity.ToTable("device_videogame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VideogameId).HasColumnName("videogame_id");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.DeviceVideogames)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("device_videogame$device_videogame_device_id_foreign");

                entity.HasOne(d => d.Videogame)
                    .WithMany(p => p.DeviceVideogames)
                    .HasForeignKey(d => d.VideogameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("device_videogame$device_videogame_videogame_id_foreign");
            });

            modelBuilder.Entity<PegiLabel>(entity =>
            {
                entity.ToTable("pegi_labels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PegiLabelVideogame>(entity =>
            {
                entity.ToTable("pegi_label_videogame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.PegiLabelId).HasColumnName("pegi_label_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VideogameId).HasColumnName("videogame_id");

                entity.HasOne(d => d.PegiLabel)
                    .WithMany(p => p.PegiLabelVideogames)
                    .HasForeignKey(d => d.PegiLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pegi_label_videogame$pegi_label_videogame_pegi_label_id_foreign");

                entity.HasOne(d => d.Videogame)
                    .WithMany(p => p.PegiLabelVideogames)
                    .HasForeignKey(d => d.VideogameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pegi_label_videogame$pegi_label_videogame_videogame_id_foreign");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("players");

                entity.HasIndex(e => e.Nickname, "players$players_nickname_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nickname");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PlayerTournament>(entity =>
            {
                entity.ToTable("player_tournament");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.TournamentId).HasColumnName("tournament_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerTournaments)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("player_tournament$player_tournament_player_id_foreign");

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.PlayerTournaments)
                    .HasForeignKey(d => d.TournamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("player_tournament$player_tournament_tournament_id_foreign");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("reviews");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VideogameId).HasColumnName("videogame_id");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reviews$reviews_player_id_foreign");

                entity.HasOne(d => d.Videogame)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.VideogameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reviews$reviews_videogame_id_foreign");
            });

            modelBuilder.Entity<SoftwareHouse>(entity =>
            {
                entity.ToTable("software_houses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.TaxId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tax_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Tournament>(entity =>
            {
                entity.ToTable("tournaments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<TournamentVideogame>(entity =>
            {
                entity.ToTable("tournament_videogame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.TournamentId).HasColumnName("tournament_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VideogameId).HasColumnName("videogame_id");

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.TournamentVideogames)
                    .HasForeignKey(d => d.TournamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tournament_videogame$tournament_videogame_tournament_id_foreign");

                entity.HasOne(d => d.Videogame)
                    .WithMany(p => p.TournamentVideogames)
                    .HasForeignKey(d => d.VideogameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tournament_videogame$tournament_videogame_videogame_id_foreign");
            });

            modelBuilder.Entity<Videogame>(entity =>
            {
                entity.ToTable("videogames");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Overview)
                    .HasColumnType("text")
                    .HasColumnName("overview");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnType("date")
                    .HasColumnName("release_date");

                entity.Property(e => e.SoftwareHouseId).HasColumnName("software_house_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.SoftwareHouse)
                    .WithMany(p => p.Videogames)
                    .HasForeignKey(d => d.SoftwareHouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("videogames$videogames_software_house_id_foreign");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
