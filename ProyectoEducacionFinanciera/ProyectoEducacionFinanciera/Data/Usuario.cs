using System;
using System.Collections.Generic;

namespace ProyectoEducacionFinanciera.Data;

public partial class Usuario
{
    public int Id { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Contraseña { get; set; }

}
