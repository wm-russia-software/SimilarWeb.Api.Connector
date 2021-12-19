using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.TotalTraffic
{
    /// <summary>
    /// Доли не дублированных визитов.
    /// </summary>
    public class DeduplicatedAudienceDedupData
    {
        #region Свойства

        [JsonProperty("total_deduplicated_audience")]
        public decimal TotalDeduplicatedAudience { get; set; }

        [JsonProperty("desktop_only_audience_share")]
        public decimal DesktopOnlyAudienceShare { get; set; }

        [JsonProperty("mobile_web_only_audience_share")]
        public decimal MobileWebOnlyAudienceShare { get; set; }

        [JsonProperty("desktop_and_mobile_web_audience_share")]
        public decimal DesktopAndMobileWebAudienceShare { get; set; }

        #endregion
    }
}
