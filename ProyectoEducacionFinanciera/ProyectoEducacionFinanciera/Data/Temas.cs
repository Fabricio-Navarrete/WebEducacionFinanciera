using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacionFinanciera.Data
{
    public class Temas
    {
        [Key]
        public int IdTema { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Icono { get; set; }
        //public virtual ICollection<Lecciones> Lecciones { get; set; } = new List<Lecciones>();
    }
}
