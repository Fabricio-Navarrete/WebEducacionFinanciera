using static System.Collections.Specialized.BitVector32;

namespace ProyectoEducacionFinanciera.Data
{
    public class AvanceLecciones
    {
        public int IdAvance { get; set; }
        public int IdEstudiante { get; set; }
        public int IdLeccion { get; set; }
        public decimal Avance { get; set; }

        public  Estudiante? Estudiante { get; set; }
        public Lecciones? Leccion { get; set; }
    }
}
