using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopKeywordAnalysis
{
    /// <summary>
    /// Нарушения трафика.
    /// </summary>
    public class TrafficBreakdown
    {
        #region Свойства

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("traffic_share")]
        public decimal TrafficShare { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("destination_url")]
        public string DestinationUrl { get; set; }

        [JsonProperty("website_categories")]
        public string WebsiteCategories { get; set; }

        #endregion
    }
}
