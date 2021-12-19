using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Запрос из метаданных в ответе на вызов метода. 
    /// </summary>
    /// <seealso cref="BaseRequest" />
    public abstract class BaseCategoryRequest : BaseRequest
    {
        #region Свойства

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        #endregion
    }
}
