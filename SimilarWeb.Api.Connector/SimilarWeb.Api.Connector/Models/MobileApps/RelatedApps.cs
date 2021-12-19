using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Связанные приложения.
    /// </summary>
    public class RelatedApps
    {
        #region Свойства

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        #endregion
    }
}
