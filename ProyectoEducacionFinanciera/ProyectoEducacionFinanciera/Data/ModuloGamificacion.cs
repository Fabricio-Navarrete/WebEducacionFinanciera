using System;
using System.Collections.Generic;

namespace ProyectoEducacionFinanciera.Data;

public partial class ModuloGamificacion
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Nivel { get; set; }

    public string? Recompensas { get; set; }

    public string? IdLeccion { get; set; }
}
