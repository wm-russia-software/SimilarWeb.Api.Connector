using Ak.Framework.Core.Extensions;
using Newtonsoft.Json;
using System;

namespace SimilarWeb.Api.Connector.Converters
{
    /// <summary>
    /// Преобразование типа double? в decimal
    /// </summary>
    /// <seealso cref="JsonConverter&lt;T&gt;" />
    internal class DecimalNullableJsonConverter : JsonConverter<decimal?>
    {
        /// <summary>
        /// Метод чтения JSON
        /// </summary>
        /// <param name="reader"><see cref="T:Newtonsoft.Json.JsonReader" /> Источник для чтения JSON данных.</param>
        /// <param name="objectType">Тип объекта.</param>
        /// <param name="existingValue">Существующее значение.</param>
        /// <param name="hasExistingValue">Признак наличия значения.</param>
        /// <param name="serializer">Сериализатор.</param>
        public override decimal? ReadJson(JsonReader reader, Type objectType, decimal? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return reader.Value.ToDecimal(null);
        }

        /// <summary>
        /// Метод записи JSON
        /// </summary>
        /// <param name="writer"><see cref="T:Newtonsoft.Json.JsonWriter" /> Писатель для записи JSON данных.</param>
        /// <param name="value">Значение для записи.</param>
        /// <param name="serializer">Сериализатор.</param>
        /// <exception cref="NotImplementedException">Тип исключения</exception>
        public override void WriteJson(JsonWriter writer, decimal? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
