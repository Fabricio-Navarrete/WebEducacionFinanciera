using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoEducacionFinanciera.Data;

public partial class Lecciones
{
    [Key]
    public int IdLeccion { get; set; }
    public int IdTema { get; set; }
    public string? Titulo { get; set; }
    public string? Descripcion { get; set; }
    public string? Imagen_Titulo { get; set; }
    public decimal Progreso { get; set; }
    [NotMapped]
    public int IdEstudiante { get; set; }

}
