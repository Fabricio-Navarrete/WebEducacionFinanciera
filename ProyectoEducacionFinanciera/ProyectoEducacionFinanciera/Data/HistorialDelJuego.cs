using System;
using System.Collections.Generic;

namespace ProyectoEducacionFinanciera.Data;

public partial class HistorialDelJuego
{
    public int Id { get; set; }

    public string? IdEstudiante { get; set; }

    public string? LogroDesbloqueado { get; set; }

    public int? PuntajeGanado { get; set; }

    public int? IdModuloGam { get; set; }

    public DateTime? Fecha { get; set; }
}
