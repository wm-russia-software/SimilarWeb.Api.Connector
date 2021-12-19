using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Данные по мобильным приложениям. 
    /// </summary>
    public class MobileAppsItem
    {
        #region Свойства

        [JsonProperty("key")]
        public int Key { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("rating")]
        public decimal Rating { get; set; }

        [JsonProperty("rating_count")]
        public int RatingCount { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        #endregion
    }
}
