using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.AudienceAnalysis
{
    /// <summary>
    /// Элемент списка из ответа на вызов метода AudienceInterests.
    /// </summary>
    public class Record
    {
        #region Свойства

        [JsonProperty("affinity")]
        public decimal? Affinity { get; set; }

        [JsonProperty("overlap")]
        public decimal? Overlap { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("has_adsense")]
        public bool HasAdSense { get; set; }

        #endregion
    }
}
