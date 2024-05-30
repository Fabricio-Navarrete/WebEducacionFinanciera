using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacionFinanciera.Data
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public string? Usuario { get; set; } 
        public string? Contraseña { get; set; }
        public string? NombreUsuario { get; set; } 
        public DateTime FechaNacimiento { get; set; }
        public decimal? Puntaje { get; set; }
        public int? Nivel { get; set; }
        public string? Email { get; set; }
        //public virtual ICollection<AvanceLecciones> AvanceLecciones { get; set; } = new List<AvanceLecciones>();

    }
}
