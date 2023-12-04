using System;
using System.Collections.Generic;
using LenninSegura2020_0313FP.Models;
using Microsoft.EntityFrameworkCore;

namespace LenninSegura2020_0313FP.Datos;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnoEscolar> AnoEscolars { get; set; }

    public virtual DbSet<Asignatura> Asignaturas { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<Maestro> Maestros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-88OL85LB\\SQLEXPRESS;Initial Catalog=LiceoBD;Integrated Security=True;Trusted_Connection=True; Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnoEscolar>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__AnoEscol__3214EC27CF008608");
        });

        modelBuilder.Entity<Asignatura>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Asignatu__3214EC276F5D9982");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Cursos__3214EC2716FDD162");
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Estudian__3214EC2722E034F9");
        });

        modelBuilder.Entity<Maestro>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Maestros__3214EC27B025D078");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
