using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Базовый класс с данными о рекламной сети. 
    /// </summary>
    public abstract class BaseAdNetworks
    {
        #region Свойства

        [JsonProperty("ad_network")]
        public string AdNetwork { get; set; }

        [JsonProperty("share")]
        public decimal Share { get; set; }

        [JsonProperty("change")]
        public decimal? Change { get; set; }

        #endregion
    }
}
