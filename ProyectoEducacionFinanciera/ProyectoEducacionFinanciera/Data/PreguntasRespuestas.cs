using System;
using System.Collections.Generic;

namespace ProyectoEducacionFinanciera.Data;

public partial class PreguntasRespuestas
{
    public int Id { get; set; }

    public string? TextoPregunta { get; set; }

    public string? OpcionesRespuesta { get; set; }

    public string? RespuestaCorrecta { get; set; }

    public int? IdLeccion { get; set; }
}
