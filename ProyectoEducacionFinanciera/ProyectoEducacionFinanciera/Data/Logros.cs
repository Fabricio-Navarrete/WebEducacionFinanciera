using System;
using System.Collections.Generic;

namespace ProyectoEducacionFinanciera.Data;

public partial class Logros
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Recompensa { get; set; }

    public int? IdLeccion { get; set; }
}
