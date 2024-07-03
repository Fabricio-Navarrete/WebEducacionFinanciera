using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

using static System.Collections.Specialized.BitVector32;

namespace ProyectoEducacionFinanciera.Data;

public partial class DbProyectoContext : DbContext
{
    public DbProyectoContext()
    {
    }

    public DbProyectoContext(DbContextOptions<DbProyectoContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudiante>().ToTable("Estudiante", "Dbo");
        modelBuilder.Entity<Temas>().ToTable("Temas", "Dbo");
        modelBuilder.Entity<Lecciones>().ToTable("Lecciones", "Dbo");
        modelBuilder.Entity<Contenido_Lecciones>().ToTable("Contenido_Lecciones", "Dbo");
        modelBuilder.Entity<Preguntas>().ToTable("Preguntas", "Dbo");
        modelBuilder.Entity<Respuestas>().ToTable("Respuestas", "Dbo");
        modelBuilder.Entity<PLANES_AHORRO>().ToTable("PLANES_AHORRO", "Dbo");
    }
    public DbSet<PLANES_AHORRO> PLANES_AHORRO { get; set; }
    public DbSet<Respuestas> Respuestas { get; set; }
    public DbSet<Contenido_Lecciones> Contenido_Lecciones { get; set; }
    public DbSet<Preguntas> Preguntas { get; set; }
    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Temas> Temas { get; set; }
    public DbSet<Lecciones> Lecciones { get; set; }

}
