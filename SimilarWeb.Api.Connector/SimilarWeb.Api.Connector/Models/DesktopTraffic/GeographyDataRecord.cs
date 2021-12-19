using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.DesktopTraffic
{
    /// <summary>
    /// Распределение по стране.
    /// </summary>
    public class GeographyDataRecord
    {
        #region Свойства

        [JsonProperty("country")]
        public int Country { get; set; }

        [JsonProperty("share")]
        public decimal Share { get; set; }

        [JsonProperty("visits")]
        public decimal Visits { get; set; }

        [JsonProperty("pages_per_visit")]
        public decimal PagesPerVisit { get; set; }

        [JsonProperty("average_time")]
        public decimal AverageTime { get; set; }

        [JsonProperty("bounce_rate")]
        public decimal BounceRate { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        #endregion
    }
}
