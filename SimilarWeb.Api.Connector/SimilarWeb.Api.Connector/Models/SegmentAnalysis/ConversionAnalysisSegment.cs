using Newtonsoft.Json;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Данные сегмента.
    /// </summary>
    /// <seealso cref="BaseSegment" />
    public class ConversionAnalysisSegment : BaseSegment
    {
        #region Свойства

        [JsonProperty("converted_visits")]
        public decimal ConvertedVisits { get; set; }

        [JsonProperty("conversion_rate")]
        public decimal ConversionRate { get; set; }

        [JsonProperty("stickiness")]
        public decimal Stickiness { get; set; }

        #endregion
    }
}
