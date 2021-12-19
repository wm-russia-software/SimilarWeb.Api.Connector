using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Utilities
{
    /// <summary>
    /// Ответ на вызов метода GetCheckCapabilities. Содержит оставшиеся обращения, фильтры разрешенных стран и доступные периоды времени для учетной записи.
    /// </summary>
    public class CheckCapabilitiesResponse
    {
        #region Свойства

        [JsonProperty("remaining_hits")]
        public int RemainingHits { get; set; }

        [JsonProperty("web_desktop_data")]
        public CapabilitiesData WebDesktopData { get; set; }

        [JsonProperty("web_mobile_data")]
        public CapabilitiesData WebMobileData { get; set; }

        [JsonProperty("app_data")]
        public CapabilitiesData AppData { get; set; }

        [JsonProperty("app_engagement_data")]
        public CapabilitiesData AppEngagementData { get; set; }

        #endregion
    }
}
