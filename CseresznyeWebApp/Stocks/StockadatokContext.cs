using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CseresznyeWebApp.Stocks
{
    public partial class StockadatokContext : DbContext
    {
        public StockadatokContext()
        {
        }

        public StockadatokContext(DbContextOptions<StockadatokContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ibmprice> Ibmprices { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=szoft2taayqb.database.windows.net;Initial Catalog=Stockadatok;Persist Security Info=True;User ID=hallgato;Password=Password123;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ibmprice>(entity =>
            {
                entity.ToTable("IBMPrices");

                entity.Property(e => e.ClosePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.HighPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LowPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OpenPrice).HasColumnType("decimal(18, 4)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
