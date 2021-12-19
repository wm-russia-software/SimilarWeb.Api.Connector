using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopWebTrafficSources
{
    /// <summary>
    /// Элемент списка с информацией о социальных сетях.
    /// </summary>
    public class Social
    {
        #region Свойства

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("share")]
        public decimal Share { get; set; }

        [JsonProperty("change")]
        public decimal? Change { get; set; }

        [JsonProperty("children")]
        public object Children { get; set; }

        #endregion
    }
}
