using System;
using System.Collections.Generic;

namespace ProyectoEducacionFinanciera.Data;

public partial class Chatboot
{
    public int Id { get; set; }

    public string? Preguntas { get; set; }

    public string? Respuestas { get; set; }

    public int? IdEstudiante { get; set; }

    public DateTime? FechaHora { get; set; }
}
