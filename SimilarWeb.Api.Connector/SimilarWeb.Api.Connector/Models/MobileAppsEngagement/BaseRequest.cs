using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileAppsEngagement
{
    /// <summary>
    /// Базовый класс запроса из метаданных.
    /// </summary>
    public abstract class BaseRequest
    {
        #region Свойства

        [JsonProperty("store")]
        public string Store { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        #endregion
    }
}
