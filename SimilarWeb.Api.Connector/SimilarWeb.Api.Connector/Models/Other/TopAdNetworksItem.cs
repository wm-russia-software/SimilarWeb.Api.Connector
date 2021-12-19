using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка лучших рекламных сетей.
    /// </summary>
    public class TopAdNetworksItem
    {
        #region Свойства

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("change")]
        public decimal Change { get; set; }

        #endregion
    }
}
