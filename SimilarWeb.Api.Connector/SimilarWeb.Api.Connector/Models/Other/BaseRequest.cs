using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Базовый класс запроса из метаданных.
    /// </summary>
    public abstract class BaseRequest
    {
        #region Свойства

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        #endregion
    }
}
