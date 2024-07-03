using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacionFinanciera.Data
{
    public class PLANES_AHORRO
    {
        [Key]
        public int id { get; set; }
        public string? goalName { get; set; }
        public decimal targetAmount { get; set; }
        public int months { get; set; }
        public DateTime createdAt { get; set; }
        public decimal currentSavings { get; set; }
        public int IdEstudiante { get; set; }
    }
}
