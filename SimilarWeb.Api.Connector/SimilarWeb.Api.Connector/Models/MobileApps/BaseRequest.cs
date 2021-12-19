using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Базовый класс запроса из метаданных. 
    /// </summary>
    public abstract class BaseRequest
    {
        #region Свойства

        [JsonProperty("store")]
        public string Store { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        #endregion
    }
}
