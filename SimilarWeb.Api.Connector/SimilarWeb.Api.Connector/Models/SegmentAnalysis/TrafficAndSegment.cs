using Newtonsoft.Json;
using System.Collections.Generic;

namespace SimilarWeb.Api.Connector.Models.SegmentAnalysis
{
    /// <summary>
    /// Траффик, вовлеченность и сегменты. 
    /// </summary>
    public class TrafficAndSegment
    {
        #region Свойства

        [JsonProperty("traffic_and_engagement")]
        public TrafficAndEngagement TrafficAndEngagement { get; set; }

        [JsonProperty("segments")]
        public List<ListSegmentsSegment> Segments { get; set; }

        #endregion
    }
}
