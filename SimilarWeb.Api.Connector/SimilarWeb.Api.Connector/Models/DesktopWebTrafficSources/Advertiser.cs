using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Данные по рекламодателю.
    /// </summary>
    public class Advertiser
    {
        #region Свойства

        [JsonProperty("share")]
        public decimal Share { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("change")]
        public decimal? Change { get; set; }

        #endregion
    }
}
