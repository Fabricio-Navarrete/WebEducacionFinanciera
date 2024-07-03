using Newtonsoft.Json;
using ProyectoEducacionFinanciera.Util;

namespace ProyectoEducacionFinanciera.Data.Dto
{
    public class ListSavingsPlan
    {
        public string? goalName { get; set; }
        [JsonConverter(typeof(DecimalJsonConverter), 2)]
        public decimal targetAmount { get; set; }
        [JsonConverter(typeof(DecimalJsonConverter), 2)]
        public decimal currentSavings { get; set; }
        public int idEstudiante { get; set; }
        public int id { get; set; }
    }
}
