using Newtonsoft.Json;

namespace ProyectoEducacionFinanciera.Util
{
    public class DecimalJsonConverter : JsonConverter
    {
        private readonly int _decimalPlaces;

        public DecimalJsonConverter(int decimalPlaces)
        {
            _decimalPlaces = decimalPlaces;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(decimal);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return Convert.ToDecimal(reader.Value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(Math.Round((decimal)value, _decimalPlaces));
        }
    }
}
