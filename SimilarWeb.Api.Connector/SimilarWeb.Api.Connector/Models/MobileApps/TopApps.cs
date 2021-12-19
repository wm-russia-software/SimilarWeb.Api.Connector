using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileApps
{
    /// <summary>
    /// Элемент списка с данными о наиболее популярных приложениях.
    /// </summary>
    public class TopApps
    {
        #region Свойства

        [JsonProperty("app")]
        public string App { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("change")]
        public int Change { get; set; }

        #endregion
    }
}
