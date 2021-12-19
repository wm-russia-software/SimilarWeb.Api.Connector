using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.SalesSolution
{
    /// <summary>
    /// Элемент списка значений источников траффика.
    /// </summary>
    public class TrafficSourcesValueItem
    {
        #region  Свойства

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("share")]
        public decimal Share { get; set; }

        #endregion
    }
}
