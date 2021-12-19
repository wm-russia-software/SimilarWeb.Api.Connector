using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Элемент списка оценок схожести веб-сайта. 
    /// </summary>
    public class SimilarSitesScoreItem
    {
        #region Свойства

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("score")]
        public decimal Score { get; set; }

        #endregion
    }
}
