using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.WebsiteContent
{
    /// <summary>
    /// Элемент списка доли субдоменов.
    /// </summary>
    public class SubdomainDataListItem
    {
        #region Свойства

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("share")]
        public decimal Share { get; set; }

        #endregion
    }
}
