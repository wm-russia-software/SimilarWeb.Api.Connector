using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Запрос из метаданных в ответе на вызов метода. 
    /// </summary>
    /// <seealso cref="BaseCategoryRequest" />
    public class AppRankRequest : BaseCategoryRequest
    {
        #region Свойства

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        #endregion
    }
}
