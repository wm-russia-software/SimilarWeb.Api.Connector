using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка по источникам траффика.
    /// </summary>
    public class TrafficSourcesItem
    {
        #region Свойства

        [JsonProperty("search")]
        public decimal Search { get; set; }

        [JsonProperty("social")]
        public decimal Social { get; set; }

        [JsonProperty("paid _referrals")]
        public decimal PaidReferrals { get; set; }

        [JsonProperty("referrals")]
        public decimal Referrals { get; set; }

        [JsonProperty("mail")]
        public decimal Mail { get; set; }

        [JsonProperty("direct")]
        public decimal Direct { get; set; }

        #endregion
    }
}
