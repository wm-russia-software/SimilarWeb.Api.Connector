using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Данные по изменению сегмента.
    /// </summary>
    public class ConversionAndSegment
    {
        #region Свойства

        [JsonProperty("conversion")]
        public Conversion Conversion { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }

        [JsonProperty("segments")]
        public List<ListSegmentsConversionAnalysisSegment> Segments { get; set; }

        #endregion
    }
}
