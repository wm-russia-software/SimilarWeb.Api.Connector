using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.MobileWebTrafficSources
{
    /// <summary>
    /// Элемент списка с данными по рефералу.
    /// </summary>
    public class Referral
    {
        #region Свойства

        [JsonProperty("share")]
        public decimal Share { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("change")]
        public decimal Change { get; set; }

        #endregion
    }
}
