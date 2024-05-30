using static System.Collections.Specialized.BitVector32;

namespace ProyectoEducacionFinanciera.Data
{
    public class ContenidoLecciones
    {
        public int IdContenido { get; set; }
        public int IdLeccion { get; set; }
        public string Title { get; set; } = null!;
        public string? VideoId { get; set; } = null!;
        public string Detalle { get; set; } = null!;

        // Propiedad de navegación hacia la entidad Leccion
        public Lecciones Lecciones { get; set; } = new Lecciones();
    }
}
