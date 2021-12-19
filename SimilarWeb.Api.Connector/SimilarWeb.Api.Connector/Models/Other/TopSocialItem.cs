using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка по лучшим социальным сетям.
    /// </summary>
    public class TopSocialItem
    {
        #region Свойства

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("change")]
        public decimal Change { get; set; }

        #endregion
    }
}
