using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка лучших стран по обмену.
    /// </summary>
    public class TopCountrySharesItem
    {
        #region Свойства

        [JsonProperty("country")]
        public int Country { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("change")]
        public decimal Change { get; set; }

        #endregion
    }
}
