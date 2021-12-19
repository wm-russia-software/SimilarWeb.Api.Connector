using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Элемент списка сегментов.
    /// </summary>
    public class ListSegmentsConversionAnalysisSegment
    {
        #region Свойства

        [JsonProperty("available_countries")]
        public List<string> AvailableCountries { get; set; }

        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("segment_id")]
        public string SegmentId { get; set; }

        [JsonProperty("site")]
        public string Site { get; set; }

        #endregion
    }
}
