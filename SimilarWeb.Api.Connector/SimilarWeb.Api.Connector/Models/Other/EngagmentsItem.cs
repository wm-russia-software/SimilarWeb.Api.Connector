using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.Other
{
    /// <summary>
    /// Показатель вовлеченности.
    /// </summary>
    public class EngagmentsItem
    {
        #region Свойства

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("visits")]
        public decimal Visits { get; set; }

        [JsonProperty("time_on_site")]
        public decimal TimeOnSite { get; set; }

        [JsonProperty("page_per_visit")]
        public decimal PagePerVisit { get; set; }

        [JsonProperty("bounce_rate")]
        public decimal BounceRate { get; set; }

        #endregion
    }
}
