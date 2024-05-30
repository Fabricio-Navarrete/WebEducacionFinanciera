using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacionFinanciera.Data;

public partial class Respuestas
{
    [Key]
    public int IdRespuesta { get; set; }
    public int IdPregunta { get; set; }
    public string? Descripcion { get; set; }
    public bool Estado { get; set; }
    public bool Correcto { get; set; }

}
