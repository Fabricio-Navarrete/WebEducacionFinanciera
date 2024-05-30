using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacionFinanciera.Data;

public partial class Contenido_Lecciones
{
    [Key]
    public int Id_Contenido { get; set; }
    public int IdLeccion { get; set; }
    public string? Title_card { get; set; }
    public string? Content { get; set; }
    public string? Card_color { get; set; }
    public string? Icon { get; set; }

}
