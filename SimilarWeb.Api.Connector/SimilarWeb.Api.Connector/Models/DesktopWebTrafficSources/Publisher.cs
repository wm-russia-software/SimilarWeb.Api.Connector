using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Данные издателя.
    /// </summary>
    public class Publisher
    {
        #region Свойства

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("share")]
        public decimal Share { get; set; }

        [JsonProperty("change")]
        public decimal? Change { get; set; }

        #endregion
    }
}
