using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace reverse_Engineering_Database_first
{
    public partial class Vehicle_EFTRYContext : DbContext
    {
        public Vehicle_EFTRYContext()
        {
        }

        public Vehicle_EFTRYContext(DbContextOptions<Vehicle_EFTRYContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<MotorCycle> MotorCycles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vehicle_EFTRY");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_Cars_CompanyId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CompanyId);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("companies");
            });

            modelBuilder.Entity<MotorCycle>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_MotorCycles_CompanyId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MotorCycles)
                    .HasForeignKey(d => d.CompanyId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
