using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Информация о сегменте. 
    /// </summary>
    /// <seealso cref="BaseSegment" />
    public class SegmentTrafficAndEngagementSegment : BaseSegment
    {
        #region Свойства

        [JsonProperty("bounce_rate")]
        public decimal BounceRate { get; set; }

        [JsonProperty("pages_per_visit")]
        public decimal PagesPerVisit { get; set; }

        [JsonProperty("visit_duration")]
        public decimal VisitDuration { get; set; }

        [JsonProperty("page_views")]
        public decimal PageViews { get; set; }

        [JsonProperty("share")]
        public decimal Share { get; set; }

        #endregion
    }
}
