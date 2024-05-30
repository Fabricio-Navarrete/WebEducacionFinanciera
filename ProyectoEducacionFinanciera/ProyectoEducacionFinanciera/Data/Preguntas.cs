using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacionFinanciera.Data;

public partial class Preguntas
{
    [Key]
    public int IdPregunta { get; set; }
    public int IdLeccion { get; set; }
    public string? Descripcion { get; set; }

    public bool Estado { get; set; }

}
