using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacionFinanciera.Data
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public string? NombreUsuario { get; set; } 
        public string? Password { get; set; }
        public string? Nombres { get; set; } 
        public string? Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal? Puntaje { get; set; }
        public int? Nivel { get; set; }
        public string? Email { get; set; }
        public string? Genero { get; set; }
        public string? Estado { get; set; }
        //public virtual ICollection<AvanceLecciones> AvanceLecciones { get; set; } = new List<AvanceLecciones>();

    }
}
