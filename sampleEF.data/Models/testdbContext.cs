using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace sampleEF.data.Models
{
  public partial class testdbContext : DbContext
  {
    public testdbContext()
    {
    }

    public testdbContext(DbContextOptions<testdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PersonDbFirst> PersonDbFirsts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("Data Source=mssql;Initial Catalog=testdb;User ID=sa;Password='cJ3\"fC7>oN3;iN4>';");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

      modelBuilder.Entity<PersonDbFirst>(entity =>
      {
        entity.HasKey(e => e.PersonId)
                  .HasName("PK__PersonDb__543848DF7556CEC7");

        entity.ToTable("PersonDbFirst");

        entity.Property(e => e.PersonId).HasColumnName("person_id");

        entity.Property(e => e.FirstName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false)
                  .HasColumnName("first_name");

        entity.Property(e => e.LastName)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false)
                  .HasColumnName("last_name");

        entity.Property(e => e.Phone)
                  .HasMaxLength(20)
                  .IsUnicode(false)
                  .HasColumnName("phone");
      });

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
